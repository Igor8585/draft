using System;


//Вернитесь к заданию 7.2.3 и дополните его код так, чтобы для вызова следующего следующего кода в консоль выводилось 2 сообщения 
//    (сначала "Метод класса BaseClass", а затем "Метод класса DerivedClass"):
class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }

    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public int counter;
    public override int Counter 
    {
        get { return counter; }
        set
        {
            if (value > 0)
            {
                counter = value;
            }
        }
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}

class Program
{
    public static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.Display();
    }
}