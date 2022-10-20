using System;
using System.Data.SqlClient;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const String CHAINE_CONNEXION = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
            var guid = Guid.NewGuid;

            Console.WriteLine(guid);
        }

        static void Connect()
        {
            SqlConnection connexion =
                new SqlConnection(CHAINE_CONNEXION);

            connexion.Open();
            Console.WriteLine("Connexion avec la BdD ouverte");
        }
    }
}