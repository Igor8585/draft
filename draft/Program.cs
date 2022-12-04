using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Создайте класс FileManager и выполните в нём множественную реализацию интерфейсов, указанных в примере выше.

public interface IFile
{
    void ReadFile();
}

public interface IBinaryFile
{
    void ReadFile();
    void OpenBinaryFile();
}

class FileManager : IFile, IBinaryFile
{
    public void OpenBinaryFile()
    {
        throw new NotImplementedException();
    }

    public void ReadFile()
    {
        throw new NotImplementedException();
    }
}
