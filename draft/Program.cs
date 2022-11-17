using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Используя консольное решение из задачи 9.3.13, реализуйте лямбда-оператор во время вызова анонимного метода.

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

            RandomNumberDelegate rnd = () => new Random().Next(0, 100);

            int result = rnd();

            Console.WriteLine(result);
        }

        static int RandomNumber()
        {
            return new Random().Next(0, 100);
        }
    }
}