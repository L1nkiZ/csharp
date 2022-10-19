using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal class Dessert : Preparation
    {
        public Dessert(String nom, bool edulcorant, float prix) : base(nom, prix)
        {
            Edulcorant = edulcorant;
        }

        public bool Edulcorant { get; set; }

      public override string ToString()
        {
            return $"{Nom}(Dessert: {Prix}€)";
        }
    }
}
