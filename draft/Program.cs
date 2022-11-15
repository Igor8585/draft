using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Создайте класс исключения Exception и переопределите его свойство Message, а также свойство HelpLink, добавив в него ссылку на внешний ресурс.

class Draft
{
    static void Main()
    {
        Exception exception = new Exception("Собственное исключение");

        exception.Data.Add("Дата создания исключения : ", DateTime.Now);

        exception.HelpLink = "www.google.ru";

        //exception.Message.("");
    }
}