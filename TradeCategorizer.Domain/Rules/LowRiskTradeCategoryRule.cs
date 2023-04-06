using TradeCategorizer.Domain.Entities;

namespace TradeCategorizer.Domain.Rules
{
    public class LowRiskTradeCategoryRule : ITradeCategoryRule
    {
        public TradeCategory Category => TradeCategory.LOWRISK;

        public bool IsTradeInCategory(ITrade trade)
        {
            return trade.Value < 1000000 && trade.ClientSector == "Public";
        }        
    }
}
