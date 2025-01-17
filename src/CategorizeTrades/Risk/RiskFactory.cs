namespace CategorizeTrades.Risk
{
    static class RiskFactory
    {
        public static IRisk Create(TypeRisk risk)
        {
            switch (risk)
            {
                case TypeRisk.Expired:
                    return new ExpiredRisk();
                case TypeRisk.HighRisk:
                    return new HighRisk();
                case TypeRisk.MediumRisk:
                    return new MediumRisk();                
                case TypeRisk.PEP:
                    return new PEPRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}