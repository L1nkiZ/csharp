using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursLinq
{
    public class Livre
    {
        public int LivreId { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int AnneeSortie { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public List<Style> Styles { get; set; } 
    }
}
