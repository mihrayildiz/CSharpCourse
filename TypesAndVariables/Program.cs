// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");

char character = 'A';
bool condition = true;
byte number4 = 0;//0-255 arası
short number3 = -32768; //16 bit
int number1 = 10; //32 bit
long number2 = 2147483647; //64 bit yer kaplar
double number5 = 10.5;
decimal number6 = 10.4m; //parasal meselelerde kullanılbilir dha hassastır.
var number7 = 10;//number7 artık bir int değer tutar
Console.WriteLine("Number1 is : {0}",number1); //{0} virgülden sonraki ilk değer 
Console.WriteLine("Number1 is : {0}",number2); 
Console.WriteLine("Number1 is : {0}",number3); 
Console.WriteLine("Number1 is : {0}",number4); 
Console.WriteLine("Number1 is : {0}",number5); 
Console.WriteLine("Number1 is : {0}",number6); 
Console.WriteLine("Character is : {0}", character); 
Console.WriteLine("Character is : {0}", (int)character); //65 yani anın sayısa karşılığı

enum Days
{
    Sunday, Monday, Tuesday, Wednesday, Friday //başlangı değeri 0 dır ama istediğin değerleri verebilirsin
}
