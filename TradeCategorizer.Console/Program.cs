using TradeCategorizer.Application;
using TradeCategorizer.Domain.Entities;
using TradeCategorizer.Domain.Rules;

var portfolio = new List<ITrade>
{
    new Trade (2000000, "Private"),
    new Trade (400000, "Public"),
    new Trade (500000, "Public"),
    new Trade (3000000, "Public")
};

var categoryRules = new List<ITradeCategoryRule>
{
    new LowRiskTradeCategoryRule(),
    new MediumRiskTradeCategoryRule(),
    new HighRiskTradeCategoryRule()
};

var tradeCategoryService = new TradeCategoryService(categoryRules);
var tradeCategories = tradeCategoryService.CategorizePortfolio(portfolio);

foreach (TradeCategory category in tradeCategories)
{
    Console.WriteLine(category);
}
