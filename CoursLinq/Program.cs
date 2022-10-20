using System;
using System.Collections.Generic;
using System.Linq;

namespace CoursLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var auteurs = Donnees.CreerAuteurs();

            var styles = Donnees.CreerStyles();

            var livres = Donnees.CreerLivres(auteurs, styles);

            var qryLivres = livres.ToList();
            Console.WriteLine("Requee de tout les livres !!");

            foreach (var item in qryLivres)
            {
                Console.WriteLine($"{item.AnneeSortie} - {item.Titre}");
            }
        }
    }
}
