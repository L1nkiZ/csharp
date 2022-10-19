using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal struct QuantitePrix
    {
        public QuantitePrix(int quantite, float prix)
        {
            Prix = prix;
            Quantite = quantite;
        }

        public int Quantite { get; set; }
        public float Prix { get; set; }
    }
}
