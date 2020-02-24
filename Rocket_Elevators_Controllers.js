class Column {
  constructor(id, nbElevators, nbFloors){
    this.id = id
    this.elevatorList = []
    this.floorList = []
    this.callButtonList = []
    
    for (var i = 1 ; i <= nbFloors ; i++){
      if (i != 1){
        var callButton = new CallButton('down', i)
        this.callButtonList.push(callButton)
      }
      if (i != nbFloors){
        var callButton = new CallButton('up', i)
        this.callButtonList.push(callButton)
      }
    }

    for (var i = 1 ; i <= nbElevators ; i++){
      var newElevator = new Elevator(i, nbFloors)
      this.elevatorList.push(newElevator)
    }

    for (var i = 1 ; i <= nbFloors ; i++){
      this.floorList.push(i)
    }
  }
}

class Elevator {
  constructor(id, nbFloors){
    this.id = id
    this.RequestButtonList = []
    this.doors = 'closed'
    this.direction = 'idle'
    this.currentFloor = 1
    this.requestFloor = []

    for (var i = 1 ; i <= nbFloors ; i++)
      this.RequestButtonList.push(i)
  }
  operateElevator(floor){
    console.log("------------------------ENTERING OPERATEELEVATOR FUNCTION------------------------")
    console.log("Elevator #" + this.id + " starts at floor" + this.currentFloor)
    while (this.currentFloor < floor){
      this.currentFloor++;
      console.log("Elevator #" + this.id + " is now at floor" + this.currentFloor)
    }
    while (this.currentFloor > floor){
      this.currentFloor--;
      console.log("Elevator is now at floor" + this.currentFloor)
    }
    console.log("Elevator #" + this.id + " finished its course at floor" + this.currentFloor)
    console.log("------------------------EXITING OPERATEELEVATOR FUNCTION------------------------")
  }
 }

class CallButton {
  constructor(direction, floor){
    this.direction = direction
    this.floor = floor
  }
}

class RequestButton {
  constructor(floor, requestedFloor){
    this.floor = floor
    this.requestedFloor = requestedFloor
  }
}

function findElevator(RequestedFloor, direction) {
  console.log('------------------------ENTERING FINDELEVATOR FUNCTION------------------------')
  var bestCase = 0;
  var bestElevator;
  column1.elevatorList.forEach(function(elevator) {
    console.log('evaluating conditions for elevator #' + elevator.id)
    if (direction == "up" && elevator.direction == 'up' && elevator.currentFloor <= RequestedFloor){
      bestCase = 4
      bestElevator = elevator;
    }
    else if (direction == "down" && elevator.direction == 'down' && elevator.currentFloor >= RequestedFloor){
      if(bestCase < 3) {
        bestCase = 3
        bestElevator = elevator;
      }
    }
    else if (elevator.direction == 'idle' && elevator.currentFloor == RequestedFloor){
      if(bestCase < 2) {
        bestCase = 2
        bestElevator = elevator;
      }
    }
    else {
      if(bestCase < 1) {
        bestCase = 1
        bestElevator = elevator;
      }
    }
  })
  console.log('this the best elevator:')
  console.log(bestElevator)
  console.log("------------------------EXITING FINDELEVATOR FUNCTION------------------------")
  return (bestElevator)
}



function requestElevator(requestedFloor, direction) {
  var bestElevator = findElevator(requestedFloor, direction)
  bestElevator.operateElevator(requestedFloor)
  return bestElevator
}

function requestFloor (elevator, floor) {
  elevator.operateElevator(floor)
}

var column1 = new Column('column1', 2, 10)

// column1.elevatorList[0].direction = 'idle'
// column1.elevatorList[0].currentFloor = 5
// column1.elevatorList[1].direction = 'up'
// column1.elevatorList[1].currentFloor = 4

// var elevator = requestElevator(5, "up")

// requestFloor(elevator, 8)
