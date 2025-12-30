public class PhoneNumber : ContactData
{
    public string Number { get; set; }
    public bool IsMobile { get; set; }

    public PhoneNumber(string number, bool isMobile)
    {
        Number = number;
        IsMobile = isMobile;
    }

    public override string ToString()
    {
        if (IsMobile)
        {
            return $"Mobile: {Number}";
        }
        else
        {
            return $"Landline: {Number}";
        }
    }
}
