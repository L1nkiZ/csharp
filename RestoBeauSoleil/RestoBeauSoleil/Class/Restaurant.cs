using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal class Restaurant
    {
        public List <Table> Table { get; set; }
        public List <Carte> Carte { get; set; }
        public int MyProperty { get; set; }
    }
}
