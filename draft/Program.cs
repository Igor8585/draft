using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Используя теоретический материал из данного юнита, постарайтесь самостоятельно реализовать явную реализацию следующего интерфейса:

public interface IWriter
{
    void Write();
}

public class Writen : IWriter
{
     void IWriter.Write()
    {

    }
}

class Program
{
    static void Main()
    {
        Writen writen = new Writen();

        ((IWriter) writen).Write();
    }
}