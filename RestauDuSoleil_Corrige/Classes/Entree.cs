using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauDuSoleil.Classes
{
    internal class Entree : Preparation
    {
        public Entree(string nom, bool froide, float prix) : base(nom, prix)
        {
            Froide = froide;
                
        }
        public bool Froide { get; set; }

        public override string ToString()
        {
            return $"{Nom} (entrée: {Prix}€)";
        }

    }
}
