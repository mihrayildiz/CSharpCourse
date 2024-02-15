// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer = new Customer();
customer.Name = "Test";  //customer Persondan miras aldığı için Name i almıştır.

Person[] persons = new Person[3]
{
                new Person{Name = "demiroğ"},  //ifadesi geçerlidir çünkü person bir class tır aslında ve tek başına anlam içerir.
                new Customer{Name = "engin"},
                new Student{Name = "derin"}
            };

foreach (var p in persons)
{
    Console.WriteLine(p.Name);
}



Console.ReadLine();




//class Person2
//{

//}

//class Student : Person,Person2   ifadesi doğru değildi çünk tek bir inheritance alınabilir 
//{
//    public string Department { get; set; }
//}
class Person
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}

//interface tek başına anlalm içermez ancak inhertiance yani evebeyn içerir
//bir classa birden fazla interface verilebilir ancak inheritance içn evebeyn verilemez.