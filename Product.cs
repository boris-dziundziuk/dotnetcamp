public class Product
{
    private string name;
    private double price;
    private double weight;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if (value.Length > 0)
            {
                name = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public double Price
    {
        get
        {
            return price;
        }

        set
        {
            if (value >= 0.01)
            {
                price = Math.Round(value,2);
            }
            else
            {
                throw new ArgumentException();
            }

        }
    }

    public double Weight
    {
        get
        {
            return weight;
        }

        set
        {
            if (value >= 0)
            {
                weight = Math.Round(value,3);
            }
            else
            {
                throw new ArgumentException();
            }

        }
    }

    public Product() : this(default, default, default) //(this(null, default, default))
    {

    }

    public Product(string name, double price, double weight)
    {
        Name = name;
        Price = price;
        Weight = weight;
    }

    public virtual void ChangePrice(double percent)
    {
        if (percent > -100)
        {
            Price = Math.Round(Price * (1 + (percent / 100)),2);
        }
        else
        {
            throw new ArgumentException();
        }    
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Price: {1}, Weight: {2}", Name, Price, Weight);
    }

    public void Parse(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException();
        }

        string[] arrayString = str.Split(" ");
        Name = arrayString[0];
        Price = Convert.ToDouble(arrayString[1]);
        if (!double.TryParse(arrayString[2], out weight))
        {
            throw new ArgumentException();
        }
        
    }

}


