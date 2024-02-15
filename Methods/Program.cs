// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;

Console.WriteLine("Hello, World!");


//don't repeat ypur self
static void Add()
{
    Console.WriteLine("Added");
}

static int Add2(int number1, int number2)
{
    return  number1 + number2 ;
}

static int Add3(int number1, int number2 =50) //default parameter, default parametre hep sonda olmalı KDV hesaplamalarında kullanılır
{
    return  number1 + number2 ;
}

//ref ve out keywordü
int number1 = 20;
int number2 = 20;
int resultref = Add4(ref number1 , number2);
Console.WriteLine("refresult : " + resultref);
Console.WriteLine("number1 : " + number1); //ref olaak yollandı ve ref olarak karşılandı bu yüzden method dşında artık 30 olur.bu arada ref olduğu için öncesinde 
//number1 set edilmiş olmalıydı.ancak out olsaydı set edilme zorunluluğu yoktu
static int Add4(ref int number1, int number2 ) //default parameter, default parametre hep sonda olmalı KDV hesaplamalarında kullanılır
{
     number1 = 30;
    return  number1 + number2 ;
}
//



Add();
Add();
Add();
var  result = Add2(20, 30);
Console.WriteLine(result);


var  result2 = Add3(20);
Console.WriteLine(result2);

//overloading

static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

//static int Multiply(int number1, int number2, int number3)
//{
//    return number1 * number2 * number3;
//}


//params ile çalışmak : aynı tipte istediğin adarveri yollayabilirsin.
static int Add5(params int[] numbers)
{
    return numbers.Sum();
    


}

//static int Add5(int number, params int[] numbers)
//{
//    return numbers.Sum();
    


//} 1 hariç geride kalankar params olduğu içi o değerleri toplar.

Console.WriteLine(Add5(1,2,3,4,5,6,7));