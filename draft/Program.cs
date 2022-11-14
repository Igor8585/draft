using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Доработайте его и сериализуйте в бинарный формат.

[Serializable]
class Contact
{
       public string Name { get; set; }
       public long PhoneNumber { get; set; }
       public string Email { get; set; }
       
       public Contact(string name, long phoneNumber, string email)
       {
           Name = name;
           PhoneNumber = phoneNumber;
           Email = email;
       }
}

class Program
{
    static void Main()
    {
        var person = new Contact("Peter",9257345579,"mail@mail.ru");

        BinaryFormatter formater = new BinaryFormatter();

        using (var fs = new FileStream(@"C:\\Users\User\Desktop\reter.dat", FileMode.OpenOrCreate))
        {
            formater.Serialize(fs, person);
        }
    }

}