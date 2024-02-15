// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Engin";
person2 = person1; //aslında addres atadım. çünkü referans türlü değişken
person1.FirstName = "Derin"; //artık person2 nin de firstname i derin olur.
Console.WriteLine(person2.FirstName);


Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardNumber = "123456789";
    //değeri gelir çünkü direk customer üzerinden erişmeye çalışıyorum.
Employee employee = new Employee();
employee.FirstName = "Veli";
//customer = employee; asla denilemez int ve stringi birbirine atayamazsın

Person person3 = customer; //customer bir persondır. Person temel sınftır.
Console.WriteLine(person3.FirstName);
//customer.creditcadnumber değeri gelmez çünkü person üstünden erişemeye çaışıyorum

Console.WriteLine(((Customer)person3).CreditCardNumber); //customer bilgisini getirmek için çünkü person3 person üzerinden türetilmişti sadece onun özelliklerine sahiptir.

PersonManager manager = new PersonManager();
manager.Add(person3);
manager.Add(customer);
manager.Add(employee);
class Person
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer :Person
{
    public string CreditCardNumber { get; set; }
}

class Employee :Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName); 
    }
}