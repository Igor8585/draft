using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Создайте класс исключения Exception и добавьте в свойство Data дату создания исключения.

class Draft
{
    static void Main()
    {
        Exception exception = new Exception();

        exception.Data.Add("Дата создания исключения : ", DateTime.Now);
    }
}