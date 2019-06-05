using System;
using System.Collections.Generic;
using System.Text;

namespace ArconClientPort.Models
{
    public class HoldingsDataModel
    {

        private int holdingID;
        private string securities;
        private double costBasis;
        private double marketValue;
        private double holdingPercentage;
        private double unrealGains;
        private double unrealGainsPercent;


        public int HoldingID
        {
            get { return holdingID; }
            set { this.holdingID = value; }
        }

        public string Securities
        {
            get { return securities; }
            set { this.securities = value; }
        }

        public double CostBasis
        {
            get { return this.costBasis; }
            set { this.costBasis = value; }
        }

        public double MarketValue
        {
            get { return marketValue; }
            set { this.marketValue = value; }
        }

        public double HoldingPercentage
        {
            get { return holdingPercentage; }
            set { this.holdingPercentage = value; }
        }

        public double UnrealGains
        {
            get { return unrealGains; }
            set { this.unrealGains = value; }
        }

        public double UnrealGainsPercent
        {
            get { return unrealGainsPercent; }
            set { this.unrealGainsPercent = value; }
        }

        public HoldingsDataModel(int holdingID, string securities, double costBasis, double marketValue, double holdingPercentage,
            double unrealGains, double unrealGainsPercent)
        {
            this.HoldingID = holdingID;
            this.Securities = securities;
            this.CostBasis  = costBasis;
            this.MarketValue = marketValue;
            this.HoldingPercentage = holdingPercentage;
            this.UnrealGains = unrealGains;
            this.UnrealGainsPercent = unrealGainsPercent;
            
        }
    }
}

