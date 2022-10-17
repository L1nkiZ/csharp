// See https://aka.ms/new-console-template for more information

using System;

namespace SecondConsoleApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            var boucle = true;
                
            Console.WriteLine("Bienvenue !");

            while (boucle)
            {
                Console.WriteLine("Donnez un chiffre entre 1 et 100 :");
                var entree = Console.ReadLine();
                var entreeint = Convert.ToInt16(entree);

                if (aleatoire == entreeint)
                {
                    Console.WriteLine("Félicitations vous avez trouvé !!");
                    boucle = false;
                }
                else if (aleatoire < entreeint)
                {
                    Console.WriteLine("Plus petit que " + entree);
                }
                else
                {
                    Console.WriteLine("Plus grand que " + entree);
                }
            }
        }
    }
}
