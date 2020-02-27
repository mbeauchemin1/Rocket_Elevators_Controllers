using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Column
    {
        public string Id;
        public int NbFloors;
        public int NbElevators;
        public List<int> ElevatorList = new List<int>();
        public List<int> CallElevatorButton = new List<int>();
        public Column(int id, int nbElevators, int nbFloors)
        {
            this.Id = id;
            this.NbFloors = nbFloors;
            this.NbElevators = nbElevators;
        }

        //Column column1 = new Column("column1", 5, 6);

    }
}
// column_list = new List<Column>();
// List<string> AuthorList = new List<string>();
// public List<int> ElevatorList = new List <int>();
// public List<int> CallElevatorButton = new List <int>();
// Battery battery = new Battery(4);
// Column column = new Column('column1', 5, 6);