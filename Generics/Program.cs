// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> sehirler = new List<string>();
sehirler.Add("Ankara");
Console.WriteLine(sehirler.Count); //count bir method değil propertidir.yalnızca get methodu vardır. yani set edilemez.


MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Bursa");
Console.WriteLine(sehirler2.Count);

MyList<int> deneme = new MyList<int>();
deneme.Add(1);

//hem int hemde string bir değer gönderebildim.Çünkü MyList t tipinde bir değer istiyor.

class MyList<T> //generic class 
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item; //son elemenın eklenmesi 
    }

    //propfull yazarak bir count methodu oluşturmaya çalıştk. arrayın uzunluğu verir bu yüzden lenght dedik
    //private int _count; propfull ile geldi 
    public int Count
    {
        get { return _array.Length; }
        //set methodunu kaldırdık çünkü count yalnızca get taşır.
        
    }



    //T : bir tip değişkeni gibi düşünülebilir. t yerine bir string  int değeri verilebili. yani class bir T tipi ile çalışır
}
