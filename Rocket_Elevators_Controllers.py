class column:
    def _init_(id, nbElevators, nbFloors):
        self.id = id
        self.elevatorList = []
        self.floorList  = []
        self.callButtonList = []

        for i in range(nbFloors)
            if i != 1
                callButton = CallButton('down', i)
                self.callButtonList.append(callButton)
            if i != nbFloors
                callButton = CallButton('up', i)
                self.callButtonList.append(callButton)

        for i in range(nbElevators)
            newElevator = Elevator(i, nbFloors)
            self.elevatorList.append(newElevator)
        
        for i in range(nbFloors)
            self.floorList.append(i)

class Elevator:
    def _init_(id, nbFloors):
        self.id = id
        self.RequestButtonList = []
        self.doors = 'closed'
        self.direction = 'idle'
        self.currentFloor = 1 
        self.requestFloor = []

        for i on range(nbFloors)
            self.RequestButtonList.append(i)

    def operateElevator(floor)
        while self.currentFloor < floor
            self.currentFloor+=1
        while self.currentFloor > floor
            self.currenrtFloor-=

class CallButton:
    def _init_(direction, floor):
        self.direction = direction
        self.floor = floor

class RequestButtonList:
    def _init_(floor, requestedFloor):
        self.floor
        self.requestedFloor

def findElevator(RequestedFloor, direction)
    bestCase = 0
    bestElevator = None
    for elevator in column1.elevatorList:
        if direction == "up" and elevator.direction == 'up' and elevator.currentFloor <= RequestedFloor:
            bestCase = 4
            bestElevator = elevator
        elif direction == "down" and elevator.direction == 'down' and elevator.currentFloor >= RequestedFloor:
            if bestCase < 3:
                bestCase = 3
                bestElevator = elevator
        elif elevator.direction == 'idle' and elevator.currentFloor == RequestedFloor:
            if bestCase < 2
                bestCase = 2
                bestElevator = elevator
        else
            if bestCase < 1:
                bestCase = 1
                bestElevator = elevator
    return (bestElevator)

# i don`t think is works like that...
def requestElevator(requestedFloor, direction)
    bestElevator = findElevator(requestedFloor, direction)
    bestElevator.operateElevator(requestedFloor)
    return bestElevator

def requestFloor (elevator, floor)
    elevator.operateElevator(floor)

column1 = column('column1', 2, 10)