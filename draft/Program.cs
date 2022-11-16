using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Создайте консольное приложение, в котором есть функция, принимающая на вход два числа int, и возвращающая результат int вычитания второго числа из первого. 
//Вызовите эту функцию в классе Main при помощи делегата и отобразите результат в консольном сообщении.

class Draft
{
  public delegate int SubtractionDelegate(int a, int b);
  static void Main()
    {
        SubtractionDelegate subtractionDelegate = Subtraction;

        int result = subtractionDelegate.Invoke(4,50);

        Console.WriteLine(result);
    }

    static int Subtraction(int value1, int value2)
    {
        return value2 - value1;
    }
}