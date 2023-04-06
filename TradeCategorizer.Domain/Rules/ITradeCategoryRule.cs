using TradeCategorizer.Domain.Entities;

namespace TradeCategorizer.Domain.Rules
{
    public interface ITradeCategoryRule
    {
        TradeCategory Category { get; }

        bool IsTradeInCategory(ITrade trade);        
    }
}
