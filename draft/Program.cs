using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения RankException. 
//    В случае исключения отобразите в консоль тип исключения (через метод GetType()).

class Draft
{
    static void Main()
    {
        try
        {
            throw new RankException("Ошибка!");
        }

        catch(RankException exc)
        {
            Console.WriteLine(exc.GetType());
        }

        finally
        {
            Console.Read();
        }
    }
}