using System;

//Установите ограничения на универсальные типы в классе Car. Такие, чтобы поле Engine могло принимать тип ElectricEngine и GasEngine,
//а параметр newPart метода ChangePart мог бы принимать только типы частей машины (Battery, Differential, Wheel).
//
//Для этого вам может понадобиться использовать один из ранее изученных принципов ООП.

class ElectricEngine : BaseEngine { }
class GasEngine : BaseEngine { }
class Battery : BaseChangePart { }
class Differential : BaseChangePart { }
class Wheel : BaseChangePart { }
class BaseEngine { }
class BaseChangePart { }
class Car<TEngine> where TEngine : BaseEngine
{
    public TEngine Engine;
    public virtual void ChangePart<TPart>(TPart newPart) where TPart : BaseChangePart
    {
    }

    public static void Main()
    {
    }
}