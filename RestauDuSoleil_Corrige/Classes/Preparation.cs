using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauDuSoleil.Classes
{
    internal abstract class Preparation
    {

        public Preparation(string nom, float prix)
        {
            Nom = nom;
            Ingredients = new List<string>();
            SetPrice(prix);
        }

        public string Nom { get; private set; }
        public List<string> Ingredients { get; set; }
        public string[] Allergenes { get; set; }
        public float Prix { get; private set; }

        public void SetIngredients(string[] ingredients)
        {
            if (ingredients.Length > 0)
            {
                foreach (var item in ingredients)
                {
                    if (item.Length == 0)
                    {
                        continue;
                    }
                    if (Ingredients.Contains(item))
                    {
                        continue;
                    }
                    Ingredients.Add(item);

                }

                Console.WriteLine($"Ajout de {Ingredients.Count} ingredeints");
            }
        }

        public void SetPrice(float price)
        {
            if (price > 0)
            {
                Console.WriteLine($"Prix fixé à {price} eur");
                Prix = price;
            }
        }
    }
}
