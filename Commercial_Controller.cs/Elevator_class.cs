using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Elevator
    {
        public int Id;
        public int NbFloors;
        public string Direction;
        public List<int> CurrentFloor;
        public List<int> FloorList;
        public int RequestedFloor;
        
        public Elevator(int id, int nbFloors)
        {
            this.Id = id;
            this.NbFloors = nbFloors;
        }
    }
}