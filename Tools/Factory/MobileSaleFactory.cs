namespace Tools.Factory;

public class MobileSaleFactory : SaleFactory
{
    private decimal _extra;
    public MobileSaleFactory(decimal extra)
    {
        _extra = extra;
    }
    public override ISale CreateSale()
    {
        return new MobileSale(_extra);
    }
}