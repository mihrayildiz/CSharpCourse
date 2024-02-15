// See https://aka.ms/new-console-template for more information
using Classes;

Console.WriteLine("Hello, World!");

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

Customer customer = new Customer();
customer.City = "Ankara";
customer.FirstName = "Engin";
customer.LastName = "Demiroğ";
customer.Id = 1;

Customer customer2 = new Customer
{
    Id = 2,
    FirstName = "Derin",
    LastName = "Demiroğ"
};
Console.WriteLine(customer2.FirstName);