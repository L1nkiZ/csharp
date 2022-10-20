using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauDuSoleil.Classes
{
    internal class Plat : Preparation
    {
        public Plat(string nom, bool vegetarien, float prix) : base(nom, prix)
        {
            Vegetarien = vegetarien;
        }

        public bool Vegetarien { get; set; }
    }
}
