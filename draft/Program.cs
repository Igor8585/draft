using System;

class User
{
	private int age;
	private string login;
	private string mail;

	public int Age
	{
		get
		{
			return age;
		}

		set
		{
			if (value < 18)
			{
				Console.WriteLine("Возраст должен быть не меньше 18");
			}
			else
			{
				age = value;
			}
		}
	}

	public string Login
    {
        get
        {
			return login;
        }
        set
        {
			if(value.Length < 3)
            {
				Console.WriteLine("Введите более 3 символов");
			}
            else
            {
				login = value;
            }
        }
    }

	public string Mail
	{
		get
		{
			return mail;
		}
		set
		{
			if (!value.Contains("@"))
			{
				Console.WriteLine("Неверно введена почта");
			}
            else
            {
				mail = value;
            }
		}
	}
}