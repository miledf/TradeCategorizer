namespace TradeCategorizer.Domain.Entities
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}
