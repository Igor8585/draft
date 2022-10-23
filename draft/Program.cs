using System;

class Company
{
	public string Type;
	public string Name;
}

class Department
{
	public Company Company;
	public City City;
}

class City
{
	public string Name;
}

class Program
{
	static void Main(string[] args)
	{
		var department = GetCurrentDepartment();
	}

	static Department GetCurrentDepartment()
	{
		// logic
		Department department = new Department();

		if(department?.Company?.Type == "Банк" && department?.Company?.Name == "Санкт-Петербург")
        {
			Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }			
	}
}