public class Pizza
{
    private string[] _allowedToppings = { "pineapple", "pepperoni" };
    private string _toppings;
    public string Topping
    {
        get { return _toppings; }
        set
        {
            if (_allowedToppings.Contains(value.ToLower()))
                _toppings = value.ToLower();
        }
    }
    private int _diameter;
    public int Diameter
    {
        get { return _diameter; }
        set
        {
            if (value >= 0)
            {
                _diameter = value;
            }
        }
    }
    private double _price;
    public double Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
            {
                _price = value;
            }
        }
    }
}
