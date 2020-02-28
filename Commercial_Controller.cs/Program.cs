using System.Collections.Generic;

namespace Commercial_Controller
{

    //battery creates columns, find best column
    public class Battery
    {
        public int nbColumns;
        public List<Column> columnList;

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
            if (requestedFloor < 1 && requestedFloor > 6 || floorNumber == 1)
            {
                bestColumn = columnList[0];
            }
            else if (requestedFloor >= 8 && requestedFloor <=26 || floorNumber == 1)
            {
                bestColumn = columnList[1];
            }
            else if(requestedFloor >= 27 && requestedFloor <= 46 || floorNumber ==1)
            {
                bestColumn = columnList[2];
            }
            else if (requestedFloor >= 47 && requestedFloor <= 66)
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
                Elevator elevator = new Elevator(i, nbFloors);
                elevatorList.Add(elevator);
                System.Console.WriteLine("this is elevator " + elevator.id);
            }
        }

        public Elevator findElevator(int requestedFloor)
        {
            int bestCase = 0;
            Elevator bestElevator = null;

            foreach (Elevator i in elevatorList)
            {
                if()
            }

        }

    }
    
    public class Elevator
    {
        public int nbFloors;
        public int id;
        
        public Elevator(int id, int nbFloors)
        {
            this.id = id;
            this.nbFloors = nbFloors;
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