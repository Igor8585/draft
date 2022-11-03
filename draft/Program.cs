using System;

abstract class Delivery
{
    public string Address;
}

class HomeDelivery : Delivery
{
    /* ... */
}

class PickPointDelivery : Delivery
{
    /* ... */
}

class ShopDelivery : Delivery
{
    /* ... */
}

abstract class Product
{
    public string Id;
    public string Name;
    public string Description;

    public Product(string id)
    {
        Id = id;
    }
}

class Appliances : Product
{
    public string newId;
    public int Power;
    public Appliances(string id) : base(id)
    {
        newId = id;
    }
}

class Electronics : Product
{
    public string newId;
    private decimal diagonal;
    public decimal Diagonal {
        get
        {
            if(diagonal < 32 || diagonal > 75)
                {
                    return 0;
                }
            else { return diagonal; }
        }

        set 
        {
            if(diagonal < 32 || diagonal > 75)
            {
                Console.WriteLine("Введите диагональ в пределах от 32 до 75");
            }
            else { diagonal = value; }
        }
      }

    public Electronics(string id) : base(id)
    {
        newId = id;
    }
}

class HouseholdTool : Product
{
    public string newId;
    public char EnergySavingClass;
    public HouseholdTool(string id) : base(id)
    {
        newId = id;
    }
}

//abstract class Basket<TProduct> where TProduct : Product
class Basket<TProduct> where TProduct : Product
{
    private TProduct[] basket;
    
    public Basket(TProduct[] basket)
    {
        this.basket = basket;
    }

    public TProduct this[int index]
    {
        get {
            if (index > 0 && index < basket.Length)
            {
                return basket[index];
            }
            else { return null; }
        } 
        private set
        {
            if (index > 0 && index < basket.Length)
            {
                basket[index] = value;
            }
        }
    }
}

class Order<TDelivery> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    public Order()
    {

    }

    // ... Другие поля
}

class Program
{
    public static void Main()
    {
        var product = new Electronics[]
        {
            new Electronics("1")
            {
                Description = "TV",
                Diagonal = 55,
                Name = "Горизонт"
            }
        };

        Order<HomeDelivery> hd = new Order<HomeDelivery>();

        Basket<Electronics> userBasket = new Basket<Electronics>(product);

        Electronics electr = userBasket[0];

        Console.WriteLine(electr);

    }
}