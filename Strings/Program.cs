// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string city = "Ankara";

Console.WriteLine(city[0]);

foreach (var item in city)
{
    Console.WriteLine(item);
}

string city2 = "İstanbl";
string result = city + city2;
Console.WriteLine(result);
Console.WriteLine("{0} {1}", city, city2);

//STRİNG İŞLEMLERİ

string sentence = "My name is Engin Demiroğ";
var result1 = sentence.IndexOf(" ");
Console.WriteLine(result1);
var result2 = sentence.EndsWith("ğ");
Console.WriteLine(result2);
var result3 = sentence.StartsWith("MY");
Console.WriteLine(result3);
var RESULT4 = sentence.Substring(3, 4);
Console.WriteLine(RESULT4);