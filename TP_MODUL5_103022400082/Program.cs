using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Erleazar"); 
    }
}

class DataGeneric<T>
{
    public T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

static void Main(string[] args)
{
    HaloGeneric halo = new HaloGeneric();
    halo.SapaUser<string>("Erleazar");

    DataGeneric<string> data = new DataGeneric<string>("103022400082");
    data.PrintData();
}