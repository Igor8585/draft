using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Существует консольное решение, которое выводит случайное целое число в диапазоне от 0 до 100 и отображает результат в консольное сообщение:
//Реализуйте в данном решении анонимный метод, не сломав логику приложения.

namespace DelegatePractices
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            //RandomNumberDelegate randomNumberDelegate = RandomNumber;
            //int result = randomNumberDelegate.Invoke();
            //Console.WriteLine(result);
            //Console.Read();

            RandomNumberDelegate rnd = delegate ()
            {
                return new Random().Next(0, 100);
            };

            int result = rnd.Invoke();

            Console.WriteLine(result);
        }

        static int RandomNumber()
        {
            return new Random().Next(0, 100);
        }
    }
}