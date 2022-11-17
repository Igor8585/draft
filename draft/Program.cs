using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Существует следующее консольное решение, которое отображает сообщение Hello World в консольном сообщении:
//Реализуйте в данном решении анонимный метод, не сломав логику приложения.

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
            ShowMessageDelegate smd = delegate (string hw)
            {
                Console.WriteLine(hw);
            };

            smd.Invoke("Hello World!");
        }

        static void ShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }
    }
}