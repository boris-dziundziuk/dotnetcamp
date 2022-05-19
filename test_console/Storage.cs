public class Storage
{
    //Не дуже зрозумів, як правильно тут працювати з масивом, бо при початку роботи з обʼєктом
    //ми не знаємо якої довжини він буде
    //а також не дуже зручно додавати нові елементи замість null елементів
    private Product[] allProducts = new Product[100]; //

    public Storage() : this(default)
    {

    }

    public Storage(params Product[] product)
    {
       for (int i = 0; i < product.Length; i++)
       {
         allProducts[i] = product[i];
       }
    }

    public Product this [int index]
    {
        get => allProducts[index];
    }

    public void AddProduct()
    {
        string product_type;
        string name;
        double price;
        double weight;
        Category meatCategory = Category.High;
        Type meatType = Type.Chicken;

        Console.WriteLine("Оберіть тип продукту: Product, Meat");
        product_type = Console.ReadLine();
        switch (product_type)
        {
            case "Product":
                Console.WriteLine("Напишіть назву товару");
                name = Console.ReadLine();
                break;
            case "Meat":
                object obj;

                Console.WriteLine("Напишіть назву товару");
                name = Console.ReadLine();

                Console.WriteLine("Оберіть категорію мʼяса: High, First, Second");
                string line = Console.ReadLine();
                if (Enum.TryParse(typeof(Category), line, out obj))
                {
                    meatCategory = (Category)obj;
                }
                else
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("Оберіть тип мʼяса: Mutton, Pork, Veal, Chicken");
                line = Console.ReadLine();
                if (Enum.TryParse(typeof(Type), line, out obj))
                {
                    meatType = (Type)obj;
                }
                else
                {
                    throw new ArgumentException();
                }
                break;
            default:
                Console.WriteLine("Такого продукту не існує");
                throw new ArgumentException();
        }
        Console.WriteLine("Введіть ціну товару");
        price = Double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть вагу товару");
        weight = Double.Parse(Console.ReadLine());

        if (product_type == "Meat")
        {
            Meat meat = new Meat(name, price, weight, meatCategory, meatType);
            for (int i = 0; i < allProducts.Length; i++)
            {
                if (allProducts[i] == null)
                {
                    allProducts[i] = meat;
                    break;
                }
            }
        }
        else
        {
            Product prod = new Product(name, price, weight);
            for (int i = 0; i < allProducts.Length; i++)
            {
                if (allProducts[i] == null)
                {
                    allProducts[i] = prod;
                    break;
                }
            }
        }
    }

    public void ShowAllProducts()
    {
        if (allProducts.Length == 0)
        {
            Console.WriteLine("Cart is empty");
        }
        else
        {
            foreach (var item in allProducts)
            {
                if (item != null)
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

    public void ShowAllMeat()
    {
        foreach (var item in allProducts)
        {
            if (item is Meat)
            {
                Meat item_ = item as Meat;
                Console.WriteLine($"Name: {item_.Name}, Price: {item_.Price}, Weight: {item_.Weight}, Category: {item_.MeatCategory}, Type: {item_.MeatType}");
            }
        }
    }

    public void ChangeAllProductsPrice(double percent)
    {
        foreach (var item in allProducts)
        {
            if (percent > -100)
            {
                item.Price = Math.Round(item.Price * (1 + (percent / 100)), 2);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }


}