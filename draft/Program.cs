using System;

class Rectangle
{
	public int a,b;

    Rectangle()
    {
        a = 6;
        b = 4;
    }

    Rectangle(int s)
    {
        a = s;
        b = s;
    }

    Rectangle(int first, int second)
    {
        a = first;
        b = second;
    }

    static int Square(int a, int b)
    {
        int s = a * b;

        return s;
    }


    static void Main()
    {

    }
}