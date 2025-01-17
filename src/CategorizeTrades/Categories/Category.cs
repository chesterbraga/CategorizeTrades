using CategorizeTrades.Risk;
using CategorizeTrades.Trades;

namespace CategorizeTrades.Categories
{
    class Category
    {
        private List<ITrade> portfolio;

        public Category(List<ITrade> portfolio)
        {
            this.portfolio = portfolio;            
        }

        public List<string> GetCategories()
        {
            List<string> tradeCategories = new List<string>();

            List<IRisk> risks = new List<IRisk> {
                RiskFactory.Create(TypeRisk.Expired),
                RiskFactory.Create(TypeRisk.HighRisk),
                RiskFactory.Create(TypeRisk.MediumRisk),                
                RiskFactory.Create(TypeRisk.PEP)
            };

            foreach (Trade trade in portfolio)
            {
                foreach (IRisk r in risks)
                {                    
                    if (trade.CalculateRisk(r))
                    {
                        tradeCategories.Add(r.Type);
                        break;
                    }
                }                
            }

            return tradeCategories;
        }
    }
}