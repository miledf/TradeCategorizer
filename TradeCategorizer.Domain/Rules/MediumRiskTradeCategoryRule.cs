using TradeCategorizer.Domain.Entities;

namespace TradeCategorizer.Domain.Rules
{
    public class MediumRiskTradeCategoryRule : ITradeCategoryRule
    {
        public TradeCategory Category => TradeCategory.MEDIUMRISK;

        public bool IsTradeInCategory(ITrade trade)
        {
            return trade.Value >= 1000000 && trade.ClientSector == "Public";
        }        
    }
}
