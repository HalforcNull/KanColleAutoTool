using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanColleAutoTool.DataEntities.ShipEntities
{
    public class Ship
    {
        public int ID { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public int condition { get; set; }
        public int artillery { get; set; }
        public int torpedo { get; set; }
        public int aa { get; set; }
        public int armor { get; set; }
        public int lucky { get; set; }
        public int scout { get; set; }
    }
}
