// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



IPersonManager  customerManager = new CustomerManager();
customerManager.Add();

IPersonManager employeeManager = new EmployeeManager();
employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new CustomerManager());
projectManager.Add(new EmployeeManager());
projectManager.Add(new InternManager());

interface IPersonManager
{
    //unimplemented operation
    void Add(); //default olarak public
    void Update();
}



class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları
        Console.WriteLine("Müşteri Eklendi.!");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi.!");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları
        Console.WriteLine("Çalışan Güncellendi.!");
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Güncellendi.!");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi.!");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
       personManager.Add();
       
    }
}