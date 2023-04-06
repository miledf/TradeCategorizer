namespace TradeCategorizer.Domain.Entities
{
    public class Trade : ITrade
    {
        public Trade(double value, string clientSector)
        {
            Value = value;
            ClientSector = clientSector;
        }

        public double Value { get; set; }
        public string ClientSector { get; set; }
    }
}
