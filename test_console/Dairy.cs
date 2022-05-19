public class Dairy : Product
{
    public DateTime ExpiryDate { get; private set; }

    public Dairy() : this(default, default, default, default)
    {

    }

    public Dairy(string name, double price, double weight, DateTime expiryDate) : base(name, price, weight)
    {
        ExpiryDate = expiryDate;
    }

    public override void ChangePrice(double percent)
    {
        if (isExpired())
        {
            percent -= 30;
        }

        base.ChangePrice(percent);
    }

    private bool isExpired()
    {
        return (DateTime.Now > ExpiryDate);
    }

    public override string ToString()
    {
        return base.ToString() + String.Format(", Expiry: {0}", ExpiryDate);
    }
}

