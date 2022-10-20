using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CoursThreads
{
    internal class MethodesAsync
    {
        public MethodesAsync()
        {
            AfficheMessage("coucou", 2);
            var ok = IsNumeric("6531");

            Task tacheAffichage = 
                Task.Run(() => AfficheMessage("Bonjour",1));

            Task<bool> tacheIsNumeric =
                Task.Run<bool>(() => IsNumeric("123"));

            tacheAffichage.Wait(); //Le thread principal attend la fin de cette tache 
            var result = tacheIsNumeric.Result;

        }

        public void AfficheMessage (string msg, int nbr)
        {
            for (int i = 0; i < nbr; i++)
            {
                Console.WriteLine($"{i} - {msg}");
            }
        }

        public bool IsNumeric (string text)
        {
            return
                short.TryParse(text, out _)
                ||
                int.TryParse(text, out _)
                ||
                long.TryParse(text, out _)
                ||
                double.TryParse(text, out _);
        }

        public async Task AfficheMessageAsync(string msg, int nbr)
        {
            for (int i = 0; i < nbr; i++)
            {
                Console.WriteLine($"{i} - {msg}");
            }

            var result = await IsNumericAsync(msg);
            if (result = true)
            {
                Console.WriteLine($"{msg} est numeric");
            }
            else
            {
                Console.WriteLine($"{msg} n'est pas numeric");
            }
        }

        public async Task<bool> IsNumericAsync(string text)
        {
            return
                short.TryParse(text, out _)
                            ||
                int.TryParse(text, out _)
                            ||
                long.TryParse(text, out _)
                ||
                double.TryParse(text, out _);
        }
    }
}
