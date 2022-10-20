using System;
using System.Collections.Generic;
using System.Text;

namespace RestauDuSoleil.Classes
{
    internal class Addition
    {
        public Addition()
        {
            Detail = new Dictionary<string, QuantitePrix>();
        }
        public int Identifiant { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, QuantitePrix> Detail { get; set; }
    }
}
