using TradeCategorizer.Domain.Entities;
using TradeCategorizer.Domain.Exceptions;
using TradeCategorizer.Domain.Rules;

namespace TradeCategorizer.Application
{
    public class TradeCategoryService
    {
        private readonly List<ITradeCategoryRule> categoryRules;

        public TradeCategoryService(List<ITradeCategoryRule> categoryRules)
        {
            this.categoryRules = categoryRules;
        }        

        public List<TradeCategory> CategorizePortfolio(List<ITrade> portfolio)
        {
            return portfolio.Select(CategorizeTrade).ToList();
        }

        private TradeCategory CategorizeTrade(ITrade trade)
        {
            foreach (var rule in categoryRules.Where(rule => rule.IsTradeInCategory(trade)))
            {
                return rule.Category;
            }

            throw new InvalidTradeException("Trade doesn't match any category rule");
        }
    }
}
