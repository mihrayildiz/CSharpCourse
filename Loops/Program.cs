// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


for (int i = 100; i >=0; i = i-2)
{
    Console.WriteLine(i);
}

for (int i = 0; i <=100; i = i+2)
{
    Console.WriteLine(i);
}

int number = 100;
while (number >=0)
{
    Console.WriteLine(number);
    number--;//sayuı düşürülmeliki sonsuz döngü olmasın
}



int number2 = 10;
do
{
    Console.WriteLine(number2);
    number2--;

}while (number2 >=0);
//şaert sağlansa da sağlanmasa da bir kz olsun döngüye girer