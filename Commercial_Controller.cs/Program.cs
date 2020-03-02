using System.Collections.Generic;

namespace Commercial_Controller
{

    //battery creates columns, find best column
    public class Battery
    {
        public int nbColumns;
        public static List<Column> columnList;

        public Battery(int nbColumns, int nbFloors, int nbElevators)
        {
            this.nbColumns = nbColumns;

            for (int i = 1; i <= nbColumns; i++)
            {
                columnList = new List<Column>();
                Column column = new Column(i, nbElevators);
                columnList.Add(column);
                System.Console.WriteLine("this is column " + column.id);
            }

        }
        public Column findColumn(int requestedFloor, int floorNumber)
        {
            Column bestColumn = null;
            if (floorNumber == 7 && requestedFloor >= 1 && requestedFloor <= 6 || floorNumber >= 1 && floorNumber <=6 && requestedFloor == 7)
            {
                bestColumn = columnList[0];
            }
            else if (floorNumber == 7 && requestedFloor >= 8 && requestedFloor <=26 || floorNumber >= 8 && floorNumber <= 26 && requestedFloor == 7)
            {
                bestColumn = columnList[1];
            }
            else if(floorNumber == 7 && requestedFloor >= 27 && requestedFloor <= 46 || floorNumber >= 27 && floorNumber <= 46 && requestedFloor ==7)
            {
                bestColumn = columnList[2];
            }
            else if (floorNumber ==7 && requestedFloor >= 47 && requestedFloor <= 66 || floorNumber >= 47 && floorNumber <= 66 && requestedFloor ==7)
            {
                bestColumn = columnList[3];
            }
            return bestColumn;
        }
    }
    
    //column creates elevators, find best elevator
     public class Column
    {
        public int id;
        public int nbFloors;
        public int nbElevators;
        public List<Elevator> elevatorList = new List<Elevator>();
        public Column(int id, int nbElevators)
        {
            this.id = id;
            this.nbElevators = nbElevators;

            for (int i = 1; i <= nbElevators; i++)
            {
                elevatorList = new List<Elevator>();
                Elevator elevator = new Elevator(i);
                elevatorList.Add(elevator);
                System.Console.WriteLine("this is elevator " + elevator.id);
            }
        }

        public Elevator findElevator(int requestedFloor, int floorNumber, string direction, int userPosition, int elevatorCurrentFloor)
        {
            int bestCase = 0;

            Elevator bestElevator = null;

            if (Battery.findColumn(requestedFloor,floorNumber).bestColumn =[0])
            {
                foreach (Elevator i in elevatorList)   
                {
                    if (requestedFloor < 7 && direction == "down" && elevatorCurrentFloor == 7 || floorNumber == 7 && direction == "up" && elevatorCurrentFloor <= userPosition)
                    {
                        bestCase = 4;
                        bestElevator = i;
                    }
                    else if (requestedFloor < 7 && direction == "idle" && elevatorCurrentFloor == 7 || floorNumber == 7 && direction == "idle " && elevatorCurrentFloor == userPosition)
                    {
                        if (bestCase < 3)
                        {
                            bestCase = 3;
                            bestElevator = i;
                        }       
                    }
                    else if (requestedFloor < 7 && direction == "idle " && elevatorCurrentFloor != 7 || floorNumber == 7 && direction == "idle" && elevatorCurrentFloor != userPosition)
                    {
                        if (bestCase < 2)
                        {
                            bestCase = 2;
                            bestElevator = i;
                        }
                        
                    }    
                    else
                    {
                        if (bestCase < 1)
                        {
                            bestCase = 1;
                            bestElevator = i;
                        }
                    }
                }
            }
            else
            {
                foreach (Elevator i in elevatorList)
                {
                    if (requestedFloor > 7 && direction == "up" && elevatorCurrentFloor == 7 || floorNumber == 7 && direction == "down" && elevatorCurrentFloor >= userPosition)
                    {
                        bestCase = 4;
                        bestElevator = i;
                    }
                    else if (requestedFloor > 7 && direction == "idle" && elevatorCurrentFloor == 7 || floorNumber == 7 && direction == "idle " && elevatorCurrentFloor == userPosition)
                    {
                        if (bestCase < 3)
                        {
                            bestCase = 3;
                            bestElevator = i;
                        }  
                    }
                    else if (requestedFloor > 7 && direction == "idle " && elevatorCurrentFloor != 7 || floorNumber == 7 && direction == "idle" && elevatorCurrentFloor != userPosition)
                    {
                        if (bestCase < 2)
                        {
                            bestCase = 2;
                            bestElevator = i;
                        }
                    }
                    else
                    {
                        if (bestCase < 1)
                        {
                            bestCase = 1;
                            bestElevator = i;
                        }
                    }
                }
            }
            return bestElevator;
        }


    public class Elevator
    {
        public int id;
        public int nbFloors;
        public  int currentFloor;
        public string direction;

        
        public Elevator(int id)
        {
            this.id = id;
            this.direction = "idle";
            this.currentFloor = 7;
        }

        public void operateElevator(int floor)
        {
            while(this.currentFloor < floor)
            {
                this.currentFloor ++;
            }
            while(this.currentFloor > floor)
            {
                this.currentFloor --;
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Battery battery = new Battery(4, 66, 5);
            //Cette méthode représente une demande d’ascenseur sur un étage ou un sous-sol
            //RequestElevator(floorNumber)
            //Cette méthode servira pour les demandes faites au 1er étage
            // AssignElevator(requestedFloor)
        }
    }
}