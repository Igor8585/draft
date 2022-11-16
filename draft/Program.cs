using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения ArgumentOutOfRangeException. 
//В случае исключения отобразите в консоль сообщение об ошибке.

class Draft
{
    static void Main()
    {
        try
        {
            throw new ArgumentOutOfRangeException("Ошибка!");
        }

        catch(ArgumentOutOfRangeException exc)
        {
            Console.WriteLine(exc.Message);
        }

        finally
        {
            Console.Read();
        }
    }
}