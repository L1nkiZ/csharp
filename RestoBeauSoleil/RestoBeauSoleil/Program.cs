// See https://aka.ms/new-console-template for more information

using RestoBeauSoleil.Class;
using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static Restaurant monRestau;

        static int GetUserEntre()
        {
            bool entryok = false;
            int val = 0;

            do
            { 
                var entry = Console.ReadLine();
                entryok = int.TryParse(entry, out val);
                if (!entryok)
                    Console.WriteLine("La saisie est incorrect");
            } while (!entryok);

            return val;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue au restorant Beau Soleil");

            /* RESTO */
            monRestau = new Restaurant()
            {
                Tables = default,
                Cartes = default,
            };


            /* TABLES */
            var tables = new List<Table>();
            tables.Add(new Table()
            {
                Places = 4,
                Identifiant = 1
            });

            tables.Add(new Table()
            {
                Places = 4,
                Identifiant = 2
            });

            tables.Add(new Table()
            {
                Places = 6,
                Identifiant = 3
            });



            /* CARTE */
            var entrees = new List<Entree>()
            {
                new Entree("Salade de Fuits", true, 2f),
                new Entree("Salade", true, 1f),
            };

            var plats = new List<Plat>()
            {
                new Plat("Sushi", false, 6.5f)
            };

            var desserts = new List<Dessert>()
            {
                new Dessert("Pomme", false, 1f)
            };

            var cartes = new List<Carte>()
            {
                new Carte(DateTime.Now, entrees, plats, desserts)
            };


            Console.WriteLine("Choisissez le menu :");
            Console.WriteLine("\t1 - Ajouter un groupe");
            Console.WriteLine("\t2 - Voir les tables disponibles");

            int val = GetUserEntre();

            switch (val)
            {
                case 1:
                    Console.WriteLine("Combien de personnes compotte le groupe ? ");
                    var nbrClientGroupe = Console.ReadLine();

                    while (nbrClientGroupe == null || nbrClientGroupe == "0")
                    {
                        Console.WriteLine("Combien de personnes compotte le groupe ? ");
                        nbrClientGroupe = Console.ReadLine();
                    }

                    var groupes = new GroupeCLients();

                    var nbrClientGroupe_int = int.TryParse(nbrClientGroupe, out nbrClientGroupe_int);


                    for (int i = 0; i < nbrClientGroupe_int; i++)
                    {
                        
                        /* GROUPES */
                        groupes.Clients.Add(new Client());
                    }

                    monRestau.Groupes.Add(groupes);
                    var tablesLibres = CheckFreeTables();
                    Console.WriteLine("Attribuer une table :");
                    foreach (var table in tablesLibres)
                    {
                        Console.WriteLine($"\t {table.Identifiant} - ({table.Places} places");
                    }

                    break;

                case 2:
                    int nbrTable = Table.Count;

                    break;

                default:
                    break;
            }

        }

        static List<Table> CheckFreeTables()
        {
            var toutes = monRestau.Groupes;
            var attribuees = monRestau.Groupes;
                .Select(groupes =>
                {
                    return groupes.Table;
                })

                .Where(tbl =>
                 {
                     return tbl != null;
                 });

            var libres = toutes.Except(attribuees);

            return libres.ToList();
        }
    }
}

