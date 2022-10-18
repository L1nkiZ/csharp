// See https://aka.ms/new-console-template for more information

using RestoBeauSoleil.Class;

var prepa1 = new Entree("Salade de fruits", true);


Console.WriteLine(prepa1.setPrice(10));

var list = new string[] { "Lait", "Farine" };
prepa1.setIngredients(list);


Console.WriteLine(prepa1.ToString());
//prepal.Nom = "Soupe de légumes";