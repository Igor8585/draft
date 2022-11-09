using System;
using System.IO;


//Напишите программу, которая выводит свой собственный исходный код в консоль.

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
        }
    }
}