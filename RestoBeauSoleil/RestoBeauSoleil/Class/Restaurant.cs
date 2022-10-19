using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal class Restaurant
    {
        public Restaurant()
        {
            Groupes = new List<GroupeCLients>();
        }

        public List <Table> Tables { get; set; }
        public List <Carte> Cartes { get; set; }
        
    }
}
