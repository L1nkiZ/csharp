using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauDuSoleil.Classes
{
    internal class Carte
    {
        public Carte(DateTime date, List<Entree> entrees, List<Plat> plats, List<Dessert> desserts)
        {
            Date = date;
            Entrees = entrees;
            Plats = plats;
            Desserts = desserts;
        }

        public DateTime Date { get; set; }
        public List<Entree> Entrees { get; set; }
        public List<Plat> Plats { get; set; }
        public List<Dessert> Desserts { get; set; }
    }
}
