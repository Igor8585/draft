using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Даны два интерфейса:
//Создайте класс ElectronicBook и выполните в нём множественную явную реализацию данных интерфейсов.

public interface IBook
{
    void Read();
}

public interface IDevice
{
    void TurnOn();
    void TurnOff();
}

class ElectronicBook : IBook, IDevice
{
    void IBook.Read()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOff()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOn()
    {
        throw new NotImplementedException();
    }
}