using System;

//Добавьте к схеме классов автомобиля следующие классы частей автомобиля: Battery, Differential, Wheel.
//Также добавьте в класс Car виртуальный обобщённый метод без реализации — ChangePart, который будет принимать один параметр — newPart универсального типа.

class ElectricEngine { }
class GasEngine { }
class Battery { }
class Differential { }
class Wheel { }
class Car<T>
{
    public T Engine;
    public virtual void ChangePart<T1>(T1 newPart)
    {
    }

    public static void Main()
    {
    }
}