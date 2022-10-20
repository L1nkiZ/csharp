using System;
using System.Collections.Generic;
using System.Linq;

namespace CoursLinq
{

    internal class Donnees
    {
        public static List<Style> CreerStyles()
        {
            return new List<Style>()
                {
                    new Style{ Id = 1, StyleName="Thriller"},
                    new Style{ Id = 2, StyleName="Sci-fi"},
                    new Style{ Id = 3, StyleName="Comédie"},
                    new Style{ Id = 4, StyleName="Cuisine"},
                    new Style{ Id = 5, StyleName="Drame"},
                    new Style{ Id = 6, StyleName="Amour"},
                    new Style{ Id = 7, StyleName="Développement Personnel"},
                    new Style{ Id = 8, StyleName="Sorcellerie"}
                };

        }

        public static List<Auteur> CreerAuteurs()
        {

            return new List<Auteur>()
            {
                new Auteur{ Id = 1,
                    Birthday = new DateTime(1789,12,24),
                    AuteurName = "Nicolas Sarkozy"
                },
                new Auteur{ Id = 2,
                    Birthday = new DateTime(1952,03,11),
                    AuteurName = "Douglas Adams"
                },
                new Auteur{ Id = 3,
                    Birthday = new DateTime(1020,12,24),
                    AuteurName = "Le Clezio"
                },
                new Auteur{ Id = 4,
                    Birthday = new DateTime(1991,11,21),
                    AuteurName = "Thomas KIEFFER"
                },
                new Auteur{ Id = 5,
                    Birthday = new DateTime(1980,12,24),
                    AuteurName = "Jean guy"
                },
                new Auteur{ Id = 6,
                    Birthday = new DateTime(1999,12,24),
                    AuteurName = "Hajime Isayama"
                },
                new Auteur{ Id = 7,
                    Birthday = new DateTime(1984,12,28),
                    AuteurName = "Eddie Malou"
                }
             };
        }

        public static List<Livre> CreerLivres(List <Auteur> auteurs, List <Style> styles) {

            return new List <Livre>()
            {
                new Livre
                {
                    ISBN = "jagdu",
                    AnneeSortie = 2000,
                    Description = "sqdvq vqs qv qfv",
                    LivreId = 1,
                    Titre = "Le manege wesh",
                    Auteurs = auteurs.Where(a => new int[]{ 1,2}.Contains( a.Id)).ToList(),
                    Styles = styles.Where(s => new int[]{ 1,2}.Contains( s.Id)).ToList()
                },
                new Livre
                {
                    ISBN = "1234567890C",
                    AnneeSortie = 2018,
                    Description = "sqdvq vqs qv qfv",
                    LivreId = 2,
                    Titre = "Le véganisme du Brasil",
                    Auteurs = auteurs.Where(a => new int[]{ 7}.Contains( a.Id)).ToList(),
                    Styles = styles.Where(s => new int[]{ 6,2}.Contains( s.Id)).ToList()
                },
                new Livre
                {
                    ISBN = "jagdu",
                    AnneeSortie = 2000,
                    Description = "sqdvq vqs qv qfv",
                    LivreId = 1,
                    Titre = "La chute du Grand Fromage",
                    Auteurs = auteurs.Where(a => new int[]{ 5}.Contains( a.Id)).ToList(),
                    Styles = styles.Where(s => new int[]{ 3,8}.Contains( s.Id)).ToList()
                },
                new Livre
                {
                    ISBN = "515555151515dqf",
                    AnneeSortie = 2004,
                    Description = "sqdvq vqs qv qfv",
                    LivreId = 4,
                    Titre = "30 recettes de poulet korma",
                    Auteurs = auteurs.Where(a => new int[]{ 1,4}.Contains( a.Id)).ToList(),
                    Styles = styles.Where(s => new int[]{ 1,2}.Contains( s.Id)).ToList()
                },
                new Livre
                {
                    ISBN = "jagdu",
                    AnneeSortie = 2000,
                    Description = "sqdvq vqs qv qfv",
                    LivreId = 1,
                    Titre = "l'age du capitaine",
                    Auteurs = auteurs.Where(a => new int[]{ 6,7}.Contains( a.Id)).ToList(),
                    Styles = styles.Where(s => new int[]{ 4,5,6}.Contains( s.Id)).ToList()
                },
                new Livre
                {
                    ISBN = "jagdu",
                    AnneeSortie = 2000,
                    Description = "sqdvq vqs qv qfv",
                    LivreId = 1,
                    Titre = "mémé dans les orties",
                    Auteurs = auteurs.Where(a => new int[]{4}.Contains( a.Id)).ToList(),
                    Styles = styles.Where(s => new int[]{ 8}.Contains( s.Id)).ToList()
                },
            };
        }
    }
}