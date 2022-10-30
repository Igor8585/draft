using System;

//Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает 2 переменные типа int и меняет их значения местами.
//
//Иными словами, для вашего метода должен будет корректно выполняться следующий код:
//int num1 = 3;
//int num2 = 58;
//
//Helper.Swap(
///*передача num1 и num2 в метод*/
//);
//
//Console.WriteLine(num1); //58
//Console.WriteLine(num2); //3

class Helper
{
    public static void Swap(ref int a, ref int b)
    {
        int temp;

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

class Program
{
    public static void Main()
    {
        int a = 3;
        int b = 58;

        Helper.Swap(ref a, ref b);
    }
}

