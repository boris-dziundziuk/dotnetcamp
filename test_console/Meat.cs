public class Meat : Product
{
    public Category MeatCategory { set; get; }

    public Type MeatType { set; get; }

    public Meat() : this(default, default, default, default, default)
    {

    }

    public Meat(string name, double price, double weight, Category meatCategory, Type meatType) : base(name, price, weight)
    {
        MeatCategory = meatCategory;
        MeatType = meatType;
    }

    public override void ChangePrice(double percent)
    {
        switch (MeatCategory)
        {
            case Category.High:
                percent += 30;
                break;
            case Category.First:
                percent += 15;
                break;
            default:
                break;
        }

        base.ChangePrice(percent);
    }

    public override string ToString()
    {
        return base.ToString() + String.Format(", MeatCategory: {0}, MeatType: {1}", MeatCategory, MeatType);
    }
}

