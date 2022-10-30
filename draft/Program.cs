using System;

//Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора был новый экземпляр класса Obj, а операции производились над полем Value.

class Obj
{
    public int Value;

    public static Obj operator + (Obj value1, Obj value2)
    {
        return new Obj()
        {
            Value = value1.Value + value2.Value
        };
    }

    public static Obj operator - (Obj value1, Obj value2)
    {
        return new Obj()
        {
            Value = value1.Value - value2.Value
        };
    }
}