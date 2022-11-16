using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Реализуйте консольное приложение, в котором существует две функции: первая функция вычитает второе число из первого и отображает результат в консольном сообщении, 
//вторая функция складывает два числа и отображает результат в консоли. Реализуйте вызов этих двух функций через многоадресный делегат.
class Draft
{
  public delegate void SubtractionDelegate(int a, int b);
  static void Main()
    {
        SubtractionDelegate subtractionDelegate = Subtraction;

        subtractionDelegate = subtractionDelegate + Addition;

        subtractionDelegate.Invoke(30,40);

    }

    static void Subtraction(int value1, int value2)
    {
         Console.WriteLine(value2 - value1);
    }

    static void Addition(int value1, int value2)
    {
        Console.WriteLine(value2 + value1);
    }
}