using System;
using System.Collections.Generic;
using System.Text;

namespace RestauDuSoleil.Classes
{
    internal struct QuantitePrix
    {
        public QuantitePrix(int quantite, float prix)
        {
            Quantite = quantite;
            Prix = prix;
        }
        public int Quantite { get; set; }
        public float Prix { get; set; }
    }
}
