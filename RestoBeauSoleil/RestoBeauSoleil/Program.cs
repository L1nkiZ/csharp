// See https://aka.ms/new-console-template for more information

using RestoBeauSoleil.Class;

Console.WriteLine("Bienvenue au restorant Beau Soleil");

/* RESTO */
var monResto = new Restaurant()
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
var choix = Console.ReadLine();

if (choix == "1")
{

    /* CLIENTS */
    var clients = new List<Client>();
    clients.Add(new Client()
    {
        Entree = "",
        Plat = "",
        Dessert = "",
        //Identifiant = 1
    });

    /* GROUPES */
    var groupes = new List<GroupeCLients>()
    {
        new GroupeCLients(clients, tables[1], addition)
    };

else
    {
        //compter les tables
    }
}

