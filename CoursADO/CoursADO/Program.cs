using System;
using System.Data.SqlClient;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const String CHAINE_CONNEXION = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection connection;

        static void Main(string[] args)
        {
            Connect();

            var sql = "SELECT * FROM testDB";
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Connection = connection;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var username = reader.GetString(1);
                var date = reader.GetDateTime(2);

                Console.WriteLine($"{id},{username},{date.ToShortDateString()}");
            }

            sql = "insert into demo (username, birthday) values '@u, @d";
            cmd = new SqlCommand(sql);
            cmd.Parameters.Add(new SqlParameter("@u", "Jean"));
            cmd.Parameters.Add(new SqlParameter("@d", DateTime.Now));

            Disconnect();
        }

        static void Connect()
        {
            connection =
                new SqlConnection(CHAINE_CONNEXION);

            connection.Open();
            Console.WriteLine("Connexion avec la BdD ouverte");
        }

        static void Disconnect()
        {
            connection.Close();
            Console.WriteLine("Connexion avec la BdD fermé");
        }
    }
}