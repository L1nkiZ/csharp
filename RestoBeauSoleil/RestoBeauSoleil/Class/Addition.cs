using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal class Addition
    {
        public Addition()
        {
            Detail = new Dictionary<string, QuantitePrix>();

            /*
            if (!detail.containskey("salade"))
            {
                detail.add("salade", new quantiteprix(3, 5f));
            }

            foreach (var item in detail)
            {
                console.writeline($"{item.key} : {item.value}");
            }
            */
        }

        public int Identifiant { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, QuantitePrix> Detail { get; set; }
    }
}
