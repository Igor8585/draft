﻿using System;



//Для класса DerivedClass создайте 2 конструктора: один, принимающий 2 параметра — name и description, второй — принимающий 3 параметра name, description и counter.
//Старайтесь написать оптимальный вариант с учетом полученных знаний.

class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    //private static string name;

    public string Description;

    public int Counter;

    public DerivedClass(string name, string description) : base(name)
    {
        Description = description;
    }

    public DerivedClass(string name, string description, int counter) : this(name, description)
    {
        //Description = description;
        Counter = counter;
    }
}
