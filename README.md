# Rocket_Elevators_Controllers
Contains the algorithm files for the elevator controllers for the New Rocket Elevator Solutions for both Residential and Commercial Offers

I don't know exactly what you need in the read me so i put the parameters for the scenario you sent last week, you can copy paste at the botton of my JavaScript and test them like you showed me in gitBash. Hope it helps. It works except if both elevator score is 1, then it will send the elevator 1. I tried but was not able to implement a findClosestElevator function by comparing the gap.

scenario 1

column1.elevatorList[0].direction = 'idle'
column1.elevatorList[0].currentFloor = 2
column1.elevatorList[1].direction = 'idle'
column1.elevatorList[1].currentFloor = 6
var elevator = requestElevator(3, "up")
requestFloor(elevator, 7)

scenario 2

column1.elevatorList[0].direction = 'idle'
column1.elevatorList[0].currentFloor = 10
column1.elevatorList[1].direction = 'idle'
column1.elevatorList[1].currentFloor = 3
var elevator = requestElevator(1, "up")
requestFloor(elevator, 6)
..........................................
column1.elevatorList[0].direction = 'idle'
column1.elevatorList[0].currentFloor = 10
column1.elevatorList[1].direction = 'idle'
column1.elevatorList[1].currentFloor = 6
var elevator = requestElevator(3, "up")
requestFloor(elevator, 5)

scenario3

column1.elevatorList[0].direction = 'idle'
column1.elevatorList[0].currentFloor = 10
column1.elevatorList[1].direction = 'idle'
column1.elevatorList[1].currentFloor = 6
var elevator = requestElevator(3, "up")
requestFloor(elevator, 5)
..........................................
column1.elevatorList[0].direction = 'idle'
column1.elevatorList[0].currentFloor = 10
column1.elevatorList[1].direction = 'idle'
column1.elevatorList[1].currentFloor = 6
var elevator = requestElevator(10, "down")
requestFloor(elevator, 3)
