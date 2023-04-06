using TradeCategorizer.Domain.Entities;

namespace TradeCategorizer.Domain.Rules
{
    public class HighRiskTradeCategoryRule : ITradeCategoryRule
    {
        public TradeCategory Category => TradeCategory.HIGHRISK;

        public bool IsTradeInCategory(ITrade trade)
        {
            return trade.Value >= 1000000 && trade.ClientSector == "Private";
        }        
    }    
}
