using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Даны три интерфейса:
//Создайте класс Entity и выполните в нём множественную неявную реализацию данных интерфейсов.

public interface ICreatable
{
    void Create();
}

public interface IDeletable
{
    void Delete();
}

public interface IUpdatable
{
    void Update();
}

class Entity : ICreatable, IDeletable, IUpdatable
{
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}