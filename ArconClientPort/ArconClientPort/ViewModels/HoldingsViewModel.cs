using ArconClientPort.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ArconClientPort.ViewModels
{
    public class HoldingsViewModel
    {
        private ObservableCollection<HoldingsDataModel> holdingData;
        public ObservableCollection<HoldingsDataModel> HoldingDataCollection
        {
            get { return holdingData; }
            set { this.holdingData = value; }
        }
        
        public HoldingsViewModel()
        {
            holdingData = new ObservableCollection<HoldingsDataModel>();
            this.GenerateHoldingData();
        }
        private void GenerateHoldingData()
        {
            holdingData.Add(new HoldingsDataModel(1001, "Berkshire Hathaway Inc Del Com Cl B", 0.00, 20450.00, 0.87, 20450.00, 0.87));
            holdingData.Add(new HoldingsDataModel(1002, "Diebold Inc Com", 0.00, 3880.55, 0.16, 3880.55, 0.16));
            holdingData.Add(new HoldingsDataModel(1003,"Fdic Insured Deposit Account Ida12 Not Covered By Sipc",0.00 ,42201.79 ,1.79,Double.NaN,Double.NaN));
            holdingData.Add(new HoldingsDataModel(1004, "General Electric Co Com", 0.00, 17451.61, 0.74, 17451.61, 0.74));
            holdingData.Add(new HoldingsDataModel(1005,"Goldmining Inc Com",0.00 ,3085.06 ,0.13,3085.06 ,0.13));
            holdingData.Add(new HoldingsDataModel(1006,"Invesco Optimum Yield Etf",0.00 ,2892.44 ,0.12,2892.44 ,0.12));
            holdingData.Add(new HoldingsDataModel(1007,"Ishares 0 - 5 Yr Tips Etf",0.00 ,143137.76 ,6.08,143137.76 ,6.08));
            holdingData.Add(new HoldingsDataModel(1008,"Navient Corp Com",0.00 ,5127.22 ,0.22,5127.22 ,0.22));
            holdingData.Add(new HoldingsDataModel(1009,"Spdr Dj Glb Rl Es Etf",0.00 ,53071.09 ,2.25,53071.09 ,2.25));
            holdingData.Add(new HoldingsDataModel(1010,"Spdr Ftse Portfolio Ln Tsr Etf",0.00 ,3025.86 ,0.13,3025.86 ,0.13));
            holdingData.Add(new HoldingsDataModel(1011,"Spdr Ftse S & P 600 Smcp Val Etf",0.00 ,90345.82 ,3.84,90345.82 ,3.84));
            holdingData.Add(new HoldingsDataModel(1012,"Spdr Portfolio Devlpd Etf",0.00 ,61566.59 ,2.62,61566.59 ,2.62));
            holdingData.Add(new HoldingsDataModel(1013,"Vanguard Gnma Fund Admiral",0.00 ,448163.44 ,19.04,448163.44 ,19.04));
            holdingData.Add(new HoldingsDataModel(1014,"Vanguard Growth Etf",0.00 ,136537.00 ,5.80,136537.00 ,5.80));
            holdingData.Add(new HoldingsDataModel(1015,"Vanguard High Div Yld Etf",0.00 ,192214.83 ,8.17,192214.83 ,8.17));
            holdingData.Add(new HoldingsDataModel(1016,"Vanguard High Yield Tax-Ex Adm Iral",0.00 ,209635.01,8.91,209635.01 ,8.91));
            holdingData.Add(new HoldingsDataModel(1017,"Vanguard Intermed Term Etf",0.00 ,128319.65 ,5.45,128319.65 ,5.45));
            holdingData.Add(new HoldingsDataModel(1018,"Vanguard Intl Bd Idx Etf",0.00 ,122265.49 ,5.19,122265.49 ,5.19));
            holdingData.Add(new HoldingsDataModel(1019,"Vanguard Mid Cap Etf",0.00 ,125952.81 ,5.35,125952.81 ,5.35));
            holdingData.Add(new HoldingsDataModel(1020,"Vanguard Pa Long Term Tax - Ex A Dmiral",0.00 ,201985.92 ,8.58,201985.92 ,8.58));
            holdingData.Add(new HoldingsDataModel(1021,"Vanguard Shrt Trm Corp Bd Etf",0.00 ,185425.14 ,7.88,185425.14 ,7.88));
            holdingData.Add(new HoldingsDataModel(1022,"Vanguard World Funds Consum St P Etf",0.00 ,145380.48 ,6.18,145380.48 ,6.18));
            holdingData.Add(new HoldingsDataModel(1023,"Vanguard World Funds Energy Et F",0.00 ,11819.47 ,0.50,11819.47 ,0.50));
        }

    }
}
