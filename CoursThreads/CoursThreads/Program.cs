using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algo sans thread");
            doJob(20, '#');
            doJob(20, '!');
            doJob(20, '+');

            Console.WriteLine(" 'Entrée' pour continuer");
            Console.ReadLine();

            Console.WriteLine("Algo avec thread");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");


            var t1 = new Thread(() => doJob(20, '#'));
            var t2 = new Thread(() => doJob(20, '!'));
            var t3 = new Thread(() => doJob(20, '+'));

            t1.Start();
            t2.Start();
            t3.Start();
        }

        static void doJob(int iterations, char caractere)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.Write(caractere);
                Thread.Sleep(50);
            }
        }
    }
}