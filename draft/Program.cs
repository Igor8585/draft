﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Используя консольное решение из предыдущей задачи 9.3.7, реализуйте применение шаблонных делегатов, описанных выше.
public class Program
{
    //delegate void ShowMessageDelegate();
    //delegate int SumDelegate(int a, int b, int c);
    //delegate bool CheckLengthDelegate(string row);

    static void Main(string[] args)
    {
        Action showMessageDelegate = ShowMessage;
        showMessageDelegate.Invoke();

        Func<int,int,int,int> sumDelegate = Sum;
        int result = sumDelegate.Invoke(1, 30, 120);
        Console.WriteLine(result);

        Predicate<string> checkLengthDelegate = CheckLength;
        bool status = checkLengthDelegate.Invoke("skill_factory");
        Console.WriteLine(status);

        Console.ReadLine();
    }

    static void ShowMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }
}