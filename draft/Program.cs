using System;
using System.IO;


//По ссылке лежит бинарный файл. В нём записана дата создания и имя операционной системы, на которой он был создан (формат данных — строка).
//
//Скачайте файл и поместите его на рабочий стол.
//
//Напишите программу, которая считает из него данные и позволит вам ответить на следующие вопросы:
//
//1.Когда файл был создан?
//
//Формат ответа: DD.MM в hh:mm
//
//2. На какой операционной системе создан файл?

class BinaryRead
{
    const string settingsFileName = @"C:\\Users\User\Desktop\BinaryFile.bin";

    static void Main()
    {
        ReadValues();
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