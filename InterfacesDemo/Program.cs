// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IWorker[] worker = new IWorker[3]
           {
                new Worker(),
                new Manager(),
                new Robot()
            };

foreach (var workerItem in worker)
{
    workerItem.Work();
}

IEat[] eats = new IEat[2]
{
                new Manager(),
                new Worker()
            };

foreach (var item in eats)
{
    item.Eat();
}



#region Interface
interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void Salary();
}

#endregion


#region "Implement class
class Manager : IWorker, ISalary, IEat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Salary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Salary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}

#endregion
