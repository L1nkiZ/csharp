using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBeauSoleil.Class
{
    /*
    public GroupeCLients()
    {
        Client = new List<Client>();

    }
    */

    internal class GroupeCLients
    {
        public List <Client> Clients { get; set; }
        public Table Table { get; set; }
        public Addition Addition { get; set; }
    }
}
