using System;
using System.Collections.Generic;
using System.Text;

namespace RestauDuSoleil.Classes
{
    internal class Dessert : Preparation
    {
        public Dessert(string nom, bool edulcorant, float prix) : base(nom, prix)
        {
            Edulcorant = edulcorant;
        }

        public bool Edulcorant { get; set; }
    }
}
