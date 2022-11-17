using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Используя консольное решение из задачи 9.3.12, реализуйте лямбда-оператор во время вызова анонимного метода.

namespace DelegatePractices
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            //ShowMessageDelegate showMessageDelegate = ShowMessage;
            //showMessageDelegate.Invoke("Hello World!");
            //Console.Read();

            //string hw = "Hello World!";
            ShowMessageDelegate smd = x => Console.WriteLine(x);

            smd.Invoke("Hello World");
        }

        static void ShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }
    }
}