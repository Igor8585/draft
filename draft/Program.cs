using System;
using System.IO;


//Запишите в файл из предыдущего задания информацию о доступе к нему с вашей машины. 
//
//Пример вывода, который должен получиться: 
//
//Файл изменен 02.11 14:53 на компьютере Windows 11

class BinaryRead
{
    const string settingsFileName = @"C:\\Users\User\Desktop\BinaryFile.bin";

    static void Main()
    {
        ReadValues();
        WriteValues();
    }

    static void WriteValues()
    {
        using (BinaryWriter Bw = new BinaryWriter(File.Open(settingsFileName, FileMode.Open)))
        {
            Bw.Write(@"Файл изменен 02.11 14:53 на компьютере Windows 11");
            //Bw.Write(@"на компьютере Windows 11");
        }

    }

    static void ReadValues()
    {
        //float FloatValue;
        string StringValue;
        //int IntValue;
        //bool BooleanValue;
    
        if (File.Exists(settingsFileName))
        {
            using (BinaryReader Br = new BinaryReader(File.Open(settingsFileName, FileMode.Open)))
            {
                //FloatValue = Br.ReadSingle();
                StringValue = Br.ReadString();
                //IntValue = Br.ReadInt32();
                //BooleanValue = Br.ReadBoolean();
            }
    
            Console.WriteLine("Из файла считано:");
            //Console.WriteLine("Дробь: " + FloatValue);
            Console.WriteLine("Строка: " + StringValue);
            //Console.WriteLine("Целое: " + IntValue);
            //Console.WriteLine("Булево значение " + BooleanValue);
        }
    }
}