using CategorizeTrades.Trades;

namespace CategorizeTrades.Risk
{
    class ExpiredRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if ( trade.RefDate.Subtract(trade.NextPaymentDate).Days > 30)
            {
                this.Type = TypeRisk.Expired.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}