using CategorizeTrades.Trades;

namespace CategorizeTrades.Risk
{
    class PEPRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.IsPoliticallyExposed)
            {
                this.Type = TypeRisk.PEP.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
