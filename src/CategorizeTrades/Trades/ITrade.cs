
using CategorizeTrades.Risk;

namespace CategorizeTrades.Trades
{
    interface ITrade
    {
        double Value { get; }
        SectorRisk ClientSector { get; }
        DateTime NextPaymentDate { get; }
        bool IsPoliticallyExposed { get; }
        DateTime RefDate { get; }
    }
}
