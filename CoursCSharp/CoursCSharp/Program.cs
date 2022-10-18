// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private int _myValue;
        public int MyValue
        {
            get
            {
                return _myValue;
            }
            set
            {
                _myValue = value;
            }
        }

        public int MyValue2 { get; set; }   //équivalent à ce qui est juste au dessus -> valeur "private int _myValue;" généré automatiquement

        //Exemple fonction
        static int CleanDatabase()
        {
            Console.WriteLine("Cleaning database since x day");
            return 150;
        }

        static int CleanDatabase(DateTime since)
        {
            Console.WriteLine($"Cleaning database since {since} day");
            return 0;
        }

        static void Main(string[] args)
        {
            const String EXEMPLE = ""; //constate, dois initialisé une valeur et la valeur ne change pas

            var x1 = CleanDatabase();
            var x2 = CleanDatabase(DateTime.Now);

        }
    }

    //<type de retour> <nomFonction()
    //{
    //  code
    //}
}