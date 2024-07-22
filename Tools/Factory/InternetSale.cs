namespace Tools.Factory;

public class InternetSale : ISale
{
    private decimal _discount;
    
    public InternetSale(decimal discount)
    {
        _discount = discount;
    }
    public decimal Earn(decimal total)
    {
        return total  * _discount;
    }
}