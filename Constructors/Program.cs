// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer = new Customer { Id =1, FirstName="Engin",City ="Ankara"};//constructor çalışır.

Customer customer1 = new Customer(2, "Derin", "Demiroğ", "Ankara");
Console.WriteLine(customer1.FirstName);

Customer customer2 = new Customer();
customer2.Id = 2;


class Customer
{
    //default constructor
    public Customer()
    {
        //customer ve customer2 da çalışır.
    }
    public Customer(int id, string firstName, string lastName, string city) //default constructor ezildi.
    {
        Id = id; //parametreli method için çalışınca döngüye girecek o  halde customer1 in değerleri aması için burada set etmelisin.
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}