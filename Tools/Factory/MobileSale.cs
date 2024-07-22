namespace Tools.Factory;

public class MobileSale : ISale
{
    private decimal _extra;
    public MobileSale(decimal extra)
    {
        _extra = extra;
    }
    public decimal Earn(decimal total)
    {
        return total + _extra;
    }
}