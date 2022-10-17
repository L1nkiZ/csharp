// See https://aka.ms/new-console-template for more information

/*
var tab1 = new int[3];
var tab2 = new int[] {1,2,8};

var entree = "23,22,50";

var vals = entree.Split(",");

for (int i = 0; i < vals.Length; i++)
{
    Console.WriteLine(vals[i]);
} 

foreach (var item in vals)
{
    Console.WriteLine(item);
}
*/

Console.WriteLine("Donnez deux séries de trois chiffres séparer par une virgule !");
Console.WriteLine("Première série :");
var serie1 = Console.ReadLine();
Console.WriteLine("Deuxième série :");
var serie2 = Console.ReadLine();

var tab_serie1 = serie1.Split(",");
var tab_serie2 = serie2.Split(",");

for (int i = 0; i < tab_serie1.Length; i++)
{
    Console.WriteLine(tab_serie1[i]);
}

foreach (var item in tab_serie2)
{
    var e = int.Parse(tab_serie1[i]);
    intTab1[i] = e;
    Console.WriteLine(item);
}
