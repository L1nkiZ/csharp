using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    internal abstract class Preparation
    {
        public Preparation(String nom, float prix)
        {
            Nom = nom;
            Ingredients = new List<string>();
            setPrice(prix);
        }

        public String Nom { get; set; }
        public float Prix { get; set; }
        public List <String> Ingredients { get; set; }
        public String[] Allergene { get; set; }

        public void setIngredients(String[] ingredients)
        {
            if (ingredients.Length > 0)
            {
                foreach (var item in ingredients)
                {
                    if (ingredients.Length == 0 || Ingredients.Contains(item))
                    {
                        continue;
                    }
                    Ingredients.Add(item);
                }
 
            }
            else
            {
                Console.WriteLine("Il faut au moins un ingrédient !");
            }

        }

        public void setPrice(float prix)
        {
            if (prix > 0)
            {
                Prix = prix;
                Console.WriteLine("Le prix est fixé à {prix} !");
            }
            else
            {
                Console.WriteLine("Un prix ne peut pas être négatif ou égale à zéro !");
            }

        }
    }


}
