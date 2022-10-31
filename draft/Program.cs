using System;

//Реализуйте класс-обобщение Record, у которого будут два универсальных параметра: один — для идентификатора записи (Id), другой — для значения записи (Value). 
//    Также в классе реализуйте поле Date типа DateTime.

class Record<T1, T2>
{
    public T1 id;

    public T2 Value;

    public DateTime Date;
}

