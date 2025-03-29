public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public bool UsResident()
    {
        if (!_country.Contains("US"))
        {
            return false;
        }

        else
        {
            return true;
        }
    }
}