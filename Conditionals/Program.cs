// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var number = 10;

if (number == 10)
{
    Console.WriteLine("Number is 10");
    //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); //single line if 
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

//iç içe if

if (number < 100)
{
    if(number <95 && number >=90)
    {

    }
    else
    {

    }
}