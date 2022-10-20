using RestauDuSoleil.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestauDuSoleil
{
    internal class Program
    {
        static Restaurant monRestau;
        static void Main(string[] args)
        {
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

            var entrees = new List<Entree>()
            {
                new Entree("Salade de pdt", true, 3f),
            };
            var plats = new List<Plat>()
            {
                new Plat("Pates carbo", false, 7.3f)
            };
            var desserts = new List<Dessert>()
            {
                new Dessert("Flan", true, 4f)
            };


            var cartes = new List<Carte>()
            {
                new Carte(DateTime.Now, entrees, plats, desserts)
            };

            monRestau = new Restaurant()
            {
                Tables = tables,
                Cartes = cartes
            };


            Console.WriteLine("Bienvenue dans le logiciel !");
            Console.WriteLine("Choisissez dans le menu:");
            Console.WriteLine("\t1 - Ajouter un groupe");
            Console.WriteLine("\t2 - Voir les tables disponibles");

            int val = GetUserEntry();

            switch (val)
            {
                case 1:
                    //ajout d'un groupe de clients
                    //demander le nombre de clients
                    //créer une instance de groupe + des instances de client
                    Console.WriteLine("Combien de personnes svp ?");
                    var nbPersonnes = GetUserEntry();
                    var grp = new GroupeClients();
                    for (int i = 0; i < nbPersonnes; i++)
                    {
                        grp.Clients.Add(new Client());
                    }

                    monRestau.Groupes.Add(grp);
                    var tablesLibres = CheckFreeTables();
                    Console.WriteLine("Attribuer une table :");
                    foreach (var item in tablesLibres)
                    {
                        Console.WriteLine($"\t{item.Identifiant} - ({item.Places} places)");
                    }

                    break;
                case 2:
                    //calcul des tables disponibles
                    break;
                default:
                    break;
            }

        }
        static int GetUserEntry()
        {
            bool entryOk = false;
            int val = 0;
            do
            {
                var entry = Console.ReadLine();
                entryOk = int.TryParse(entry, out val);
                if (!entryOk)
                    Console.WriteLine("La saisie est incorrecte, merci de réessayer.");
            } while (!entryOk);

            return val;
        }

        static List<Table> CheckFreeTables()
        {
            var toutes = monRestau.Tables;          

            var attribuees = monRestau.Groupes
                .Select(grp => grp.Table)
                .Where(tbl => tbl != null);

            var libres = toutes.Except(attribuees);

            return libres.ToList();
        }
    }
}
