using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal class Entree : Preparation
    {
        public Entree (String nom, bool froide ) : base(nom)
        {
            Froide = froide;
        }

        public bool Froide { get; set; }

        public override string ToString()
        {
            return $"{Nom}(entrée: {Prix}€)";
        }
    }
}
