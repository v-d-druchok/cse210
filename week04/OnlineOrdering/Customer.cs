public class Custumer 
{
    private string _name;
    private Address _address;

    public bool InUs()
    {
        if (!_address.Contains("US"))
        {
            return false;
        }

        else
        {
            return true;
        }
    }
}