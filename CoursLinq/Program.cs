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
            Console.WriteLine("Tous les livres !!");

            foreach (var item in qryLivres)
            {
                Console.WriteLine($"{item.AnneeSortie} - {item.Titre}");
            }

            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Livre sortis un fois filtré ( après 2010 ) :");
            qryLivres = livres.Where(item => item.AnneeSortie > 2010)
                .ToList();

            foreach (var item in qryLivres)
            {
                Console.WriteLine($"{item.AnneeSortie} - {item.Titre}");
            }

            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Livre qui ont plusieurs auteurs :");
            qryLivres = livres.Where(item => item.Auteurs.Count > 1)
                .ToList();

            foreach (var item in qryLivres)
            {

                var authorNames = item.Auteurs.Select(auteur => auteur.AuteurName)
                     .ToList();

                string names = string.Join(", ", authorNames);

                Console.WriteLine($"{names} - {item.Titre}");
            }

            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Le nombre de livre dont le style est Sci-fi");

            /*
            var qrySciFi = livres.Where(livre => livre.Styles.Any(style => style.Id == 2));
            int nbQrySciFi = qrySciFi.Count();
            */

            var nbQrySciFi = livres.Count(livre => livre.Styles.Any(style => style.Id == 2));

            Console.WriteLine($"Il y à {nbQrySciFi} livres sur la Science fi");

            /*
            var scifi = styles.First(Style => Style.Id == 2);

            qryScifi = livres.Where(livre => livre.Styles.Contains(scifi));
            nbQrySciFi = qryScifi.Count();

            livres.Where(livre => livre.Styles.Any(style => style.Id == 2));

            int nbQrySciFi = qrySciFi.Count();

            Console.WriteLine($"Il y à {nbQrySciFi} livres sur la Science fi");
            */

            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Le nom de tout les auteurs de Science fi");

            var AuteurLivreSciFI = livres.Where(livre => livre.Styles.Any(style => style.Id == 2));

            foreach (var item in AuteurLivreSciFI)
            {
                var authorNamesSciFi = item.Auteurs.Select(auteur => auteur.AuteurName)
                     .ToList();

                string namesAuteurSciFI = string.Join(", ", authorNamesSciFi);

                Console.WriteLine($"{namesAuteurSciFI} - {item.Titre}");
            }
        }
    }
}
