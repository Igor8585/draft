using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Реализуйте данный интерфейс в классе UserService, и продемонстрируйте контравариацию интерфейса в базовом классе Program.

public class User
{

}

public class Account : User
{

}

public interface IUpdater<in T>
{
    void Update(T entity);
}

class UserService : IUpdater<User>
{
    public void Update(User entity)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        var user = new User();
        var account = new Account();


        IUpdater<Account> updater = new UserService();
       // IUpdater<User> updater1 = new UserService();

        var userService = new UserService();
        userService.Update(user);
    }
}