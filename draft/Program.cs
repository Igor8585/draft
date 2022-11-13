using System;
using System.IO;


//Сделайте так, чтобы ваша программа из задания 8.3.1 при каждом запуске добавляла в свой исходный код комментарий о времени последнего запуска. 
//
//Для этого самостоятельно изучите документацию класса FileInfo и найдите метод, который позволяет добавлять строки в уже существующий файл. 

class SourceCode
{
    public static void Main()
    {
        string pathFile = @"C:\Users\User\source\repos\draft\draft\Program.cs";

        if (!File.Exists(pathFile))
        {
            string pathFile2 = @"C:\Users\User\source\repos\draft\draft\Program2.cs";

            using (StreamWriter sw = File.CreateText(pathFile2))
            {
                sw.WriteLine("using System;");
                sw.WriteLine("class SourceCode2");
                sw.WriteLine("{}");
            }
        }

        using (StreamReader sr = File.OpenText(pathFile))
        {
            string str = "";

            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine($"Время запуска {DateTime.Now}");
        }
    }
}