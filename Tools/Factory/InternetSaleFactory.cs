namespace Tools.Factory;

public class InternetSaleFactory : SaleFactory
{
    private decimal _discount;
    public InternetSaleFactory(decimal discount)
    {
        _discount = discount;
    }
    public override ISale CreateSale()
    {
        return new InternetSale(_discount);
    }
}