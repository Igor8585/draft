using System;


//Измените свойство Counter так, чтобы его можно было переопределить в классе DerivedClass. Переопределите данное свойство, ограничив занесения в него чисел меньше 0.

class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
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
}