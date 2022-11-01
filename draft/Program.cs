using System;

//С учётом полученных знаний по наследованию обобщений, дополните схему классов автомобиля, добавив классы для электромобиля и бензинового — ElectricCar и GasCar.
//
//Подумайте, какой класс или классы можно сделать абстрактными. Сделайте абстрактными их и их члены (по возможности).

class ElectricEngine : BaseEngine { }
class GasEngine : BaseEngine { }
class Battery : BaseChangePart { }
class Differential : BaseChangePart { }
class Wheel : BaseChangePart { }
abstract class BaseEngine { }
abstract class BaseChangePart { }
abstract class Car<TEngine> where TEngine : BaseEngine
{
    public TEngine Engine;
    public abstract void ChangePart<TPart>(TPart newPart) where TPart : BaseChangePart;

    public static void Main()
    {
    }
}

class ElectricCar : Car<ElectricEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}

class GasCar : Car<GasEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}