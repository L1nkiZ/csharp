using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal class Carte
    {
        public Carte(DateTime date, Entree[] entrees, Plat[] plats, Dessert[] desserts)
        {
               
        }

        public DateTime date { get; set; }
        public List <Entree> entrees { get; set; }
        public List <Plat> plats { get; set; }
        public List <Dessert> desserts { get; set; }
    }
}

