// See https://aka.ms/new-console-template for more information

using System;

namespace SecondConsoleApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* !! PREMIER EXEMPLES - INTRO CSHARP
             
            //Lecture d'une entrée utilisateur
            Console.WriteLine("Hello World!");
            Console
                .
                WriteLine("This is a second line");
            //Ecriture d'une variable
            var entree = Console.ReadLine();
            Console.WriteLine("Vous avez écris "+entree);
            Console.WriteLine("Fin");


            byte octet = 42;
            int entier = octet;
            octet = (byte)entier;

            var a1 = 4 + 4;
            var a2 = "4" + "4";
            var a3 = Convert.ToInt16(a2);

            var a4 = int.Parse(a2);
            */

            var random = new Random();
            var aleatoire = random.Next(1, 100);

            Console.WriteLine("Bienvenue !");

            var tentative = 0;
            var entree_int = 0;

            while (aleatoire != entree_int)
            {
                Console.WriteLine("Donnez un chiffre entre 1 et 100 :");
                var entree = Console.ReadLine();

                var ok = int.TryParse(entree, out entree_int);

                while (ok != true)
                {
                    Console.WriteLine("Donnez un chiffre entre 1 et 100 :");
                    entree = Console.ReadLine();
                    ok = int.TryParse(entree, out entree_int);
                }

                tentative = tentative + 1;

                if (aleatoire < entree_int)
                {
                    Console.WriteLine("Plus petit que " + entree);
                }
                else
                {
                    Console.WriteLine("Plus grand que " + entree);
                }
            }
            Console.WriteLine("Félicitations, vous avez trouvé en" + tentative + " tentative(s) !!");
        }
    }
}
