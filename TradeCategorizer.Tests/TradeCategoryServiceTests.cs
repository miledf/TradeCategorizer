using TradeCategorizer.Application;
using TradeCategorizer.Domain.Entities;
using TradeCategorizer.Domain.Exceptions;
using TradeCategorizer.Domain.Rules;

namespace TradeCategorizer.Tests
{
    public class TradeCategoryServiceTests
    {
        private readonly TradeCategoryService tradeCategoryService;
        private readonly List<ITradeCategoryRule> CategoryRules = new()
        {
            new LowRiskTradeCategoryRule(),
            new MediumRiskTradeCategoryRule(),
            new HighRiskTradeCategoryRule()
        };

        public TradeCategoryServiceTests()
        {
            tradeCategoryService = new TradeCategoryService(CategoryRules);
        }

        [Fact]
        public void TradeCategoryServiceValidInputCreatesTradeObject()
        {
            double value = 1000000;
            string clientSector = "Public";

            var trade = new Trade(value, clientSector);

            Assert.Equal(value, trade.Value);
            Assert.Equal(clientSector, trade.ClientSector);
        }

        [Fact]
        public void TradeCategoryServiceCategorizeTradesReturnsExpectedCategories()
        {
            var trades = new List<ITrade>()
            {
                new Trade(2000000, "Private"),
                new Trade(400000, "Public"),
                new Trade(500000, "Public"),
                new Trade(3000000, "Public")
            };

            var result = tradeCategoryService.CategorizePortfolio(trades);

            Assert.Equal(new List<TradeCategory> {
                TradeCategory.HIGHRISK, TradeCategory.LOWRISK, TradeCategory.LOWRISK, TradeCategory.MEDIUMRISK }, result);
        }

        [Fact]
        public void CategorizePortfolioShouldThrowExceptionWhenTradeDoesNotMatchAnyCategoryRule()
        {
            var portfolio = new List<ITrade> { new Trade(500000, "Private") }; // Doesn't match any category rule       

            Assert.Throws<InvalidTradeException>(() => tradeCategoryService.CategorizePortfolio(portfolio));
        }
    }
}
