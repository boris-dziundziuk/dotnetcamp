public class Buy
{
    public int NumberOfItems { get; private set; }

    public double TotalPrice { get; private set; }

    public double TotalWeight { get; private set; }

    private List<Product> AddedToCart;

    public Buy() : this(null)
    {

    }

    public Buy(params Product[] products)
    {
        NumberOfItems = products.Length;
        AddedToCart = new List<Product>();
        foreach (var item in products)
        {
            TotalPrice += item.Price;
            TotalWeight += item.Weight;
            AddedToCart.Add(item);
        }
    }

    //Додати товар до кошика
    public void AddProduct(Product product)
    {
        if (product != null)
        {
            AddedToCart.Add(product);
            NumberOfItems++;
            TotalPrice += product.Price;
            TotalWeight += product.Weight;
        }
        else
        {
            throw new ArgumentException();
        }

    }

    //Подивитись, що додано до кошика з урахуванням усієї інформації про товар
    public void ShowAllProducts()
    {
        if (NumberOfItems == 0)
        {
            Console.WriteLine("Cart is empty");
        }
        else
        {
            foreach (var item in AddedToCart)
            {
                string str = $"Name: {item.Name}, Price: {item.Price}, Weight: {item.Weight}";

                if (item is Meat)
                {
                    Meat item_ = item as Meat;
                    str += $", Category: {item_.MeatCategory}, Type: {item_.MeatType}";
                }

                if (item is Dairy)
                {
                    Dairy item_ = item as Dairy;
                    str += $", ExpiryDate: {item_.ExpiryDate}";
                }

                Console.WriteLine(str);
            }
        }
    }
}


