using System;

namespace draft
{
    class Program
    {
        static void Main()
        {
            byte age = 37;

            ChangeAge(age);

            Console.WriteLine(age);
        }

        static void ChangeAge(byte age)
        {
            age = (byte)Convert.ToInt32(Console.ReadLine());
        }
    }
}
