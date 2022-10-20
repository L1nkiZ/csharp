using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauDuSoleil.Classes
{
    internal class Restaurant
    {
        public Restaurant()
        {
            Groupes = new List<GroupeClients>();

        }
        public List<Table> Tables { get; set; }
        public List<Carte> Cartes { get; set; }
        public List<GroupeClients> Groupes { get; set; }

    }
}
