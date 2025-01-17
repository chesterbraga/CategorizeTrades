﻿using CategorizeTrades.Trades;

namespace CategorizeTrades.Risk
{
    class HighRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == SectorRisk.Private)
            {
                this.Type = TypeRisk.HighRisk.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}