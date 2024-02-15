// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] ogrenciler = new string[3];

ogrenciler[0] = "Engin";
ogrenciler[1] = "Derin";
ogrenciler[2] = "Salih";

foreach (string s in ogrenciler)
{
    Console.WriteLine(s);
}

string[] student = { "Salih", "Derin", "Engin" };
foreach (var s in student)
{
    Console.WriteLine(s);
}