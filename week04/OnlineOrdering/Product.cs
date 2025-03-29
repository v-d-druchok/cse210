public class Product 
{
    private string _name;
    private int _id;
    private double _price; 
    private int _quantity;

    public double ProductCost()
    {
        return _price * _quantity;
    }

}