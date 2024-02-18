// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Category> categories = new List<Category>()
{
    new Category{ CategoryId=1, CategoryName= "Bilgisayar"},
    new Category{ CategoryId=2, CategoryName= "Telefon"}
};

List<Product> products = new List<Product>()
{
    new Product{ ProductId=1,CategoryId= 1, ProductName= "Acer Laptop",
    QuentityPerUnit = "32 GB Ram", UnitPrice=1000, UnitsInStock=5},

    new Product{ ProductId=2,CategoryId= 1, ProductName= "Asus Laptop",
    QuentityPerUnit = "16 GB Ram", UnitPrice=8000, UnitsInStock=5},
     
    new Product{ ProductId=3,CategoryId= 1, ProductName= "HP Laptop",
    QuentityPerUnit = "8GB Ram", UnitPrice=6000, UnitsInStock=2},
    
    new Product{ ProductId=4,CategoryId= 2, ProductName= "Samsug Telefon",
    QuentityPerUnit = "4 GB Ram", UnitPrice=5000, UnitsInStock=15},
          
    new Product{ ProductId=5,CategoryId= 2, ProductName= " Apple Telefon",
    QuentityPerUnit = "4 GB Ram", UnitPrice=8000, UnitsInStock=0}


};

foreach (Product product in products)
{
    if(product.UnitPrice > 5000 && product.UnitsInStock >3)
    {
        Console.WriteLine(product.ProductName);
    }
    
    
}

Console.WriteLine("Linq----");

var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock >3);

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}


static List<Product> GetProductsLinq(List<Product> products)
{
    return  products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; } //Bir ürün hangi kategoride
    public string ProductName { get; set; }
    public string QuentityPerUnit { get; set; }
    public int UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}