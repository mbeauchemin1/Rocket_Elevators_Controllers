using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Battery
    {
        public int NbColumns;
        public List<int> ColumnList = new List<int>();
        public Battery(int nbColumns)
        {
            this.NbColumns = nbColumns;
        }
        public Battery battery = new Battery(4);
    }  

    


}

// public void addColumnInColumnList()
// {
// for (int i = 0, i <= NbColumns, i++)
// }