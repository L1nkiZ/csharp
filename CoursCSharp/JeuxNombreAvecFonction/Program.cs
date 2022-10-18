// See https://aka.ms/new-console-template for more information

using System;

namespace SecondConsoleApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int NeedANumber()
            {
                var entree_int = 0;
                var try_int = false;
                var entree = "";

                while (try_int != true)
                {
                    Console.WriteLine("Donnez un chiffre entre 1 et 100 :");
                    entree = Console.ReadLine();
                    try_int = int.TryParse(entree, out entree_int);
                }

                return entree_int;

            }

            var random = new Random();
            var aleatoire = random.Next(1, 100);
            var tentative = 0;
            var intEntree = 0;

            Console.WriteLine("Bienvenue !");

            while (aleatoire != intEntree)
            {
                intEntree = NeedANumber();

                tentative = tentative + 1;

                if (aleatoire < intEntree)
                {
                    Console.WriteLine("Plus petit que " + intEntree);
                }
                else
                {
                    Console.WriteLine("Plus grand que " + intEntree);
                }
            }
            Console.WriteLine("Félicitations, vous avez trouvé en " + tentative + " tentative(s) !!");
        }
    }
}
