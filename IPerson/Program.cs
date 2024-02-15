// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");


PersonManager personManager = new PersonManager();
personManager.Add(new Customer { FirstName = "Engin", LastName ="Demiroğ", Id = 1, Address="Ankara" });

Student student = new Student
{
    Id = 2,
    FirstName = "Derin",
    LastName = "Demiroğ",
    Department = "IT"
};
personManager.Add(student);

//add methodu interface i parametre olara aldğı için içerisine sudent ya da customer verebilirim 
interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }


}


class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set ; }

    public string Address { get; set; }
}


class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string  Department { get; set; }
}
class PersonManager
{
    public void Add(IPerson person) // parametre olarak bir müşteri nesnesi istiyor müşteri ekleyecek
    {
        Console.WriteLine(person.FirstName);
    }
}


