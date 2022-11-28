using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Реализуйте явно следующий интерфейс и вызовите его метод в классе Program.

public interface IWorker
{
    public void Build();
}

public class Worker : IWorker
{
     void IWorker.Build()
    {

    }
}

class Program
{
    static void Main()
    {
        var worker = new Worker();
        ((IWorker)worker).Build();
    }

}