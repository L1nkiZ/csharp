using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal class Plat : Preparation
    {
        public Plat(String nom, bool vege) : base(nom)
        {
            Vege = vege;
        }

        public bool Vege { get; set; }

        public override string ToString()
        {
            return $"{Nom}(plat: {Prix}€)";
        }
    }
}
