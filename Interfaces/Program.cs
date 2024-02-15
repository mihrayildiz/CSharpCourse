// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal());
customerManager.Add(new OracleCustomerDal());

ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new OracleCustomerDal(),
    new SqlServerCustomerDal()
};

foreach (var item in customerDals)
{
    item.Update();
}

interface ICustomerDal
{
    void Add();
    void Update();
    void Delete();
}

class SqlServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Sql Added!");
    }

    public void Delete()
    {
        Console.WriteLine("Sql Delete!");
    }

    public void Update()
    {
        Console.WriteLine("Sql Update!");
    }
}

class OracleCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Oracle Added!");
    }

    public void Delete()
    {
        Console.WriteLine("Oracle Delete!");
    }

    public void Update()
    {
        Console.WriteLine("Oracle Update!");
    }



}

 class CustomerManager
{
   public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();
    }
}

