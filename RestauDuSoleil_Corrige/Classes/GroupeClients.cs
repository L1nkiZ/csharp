using System;
using System.Collections.Generic;
using System.Text;

namespace RestauDuSoleil.Classes
{
    internal class GroupeClients
    {
        public GroupeClients()
        {
            Clients = new List<Client>();
        }
        public Table Table { get; set; }
        public List<Client> Clients { get; set; }
        public Addition Addition { get; set; }

    }
}
