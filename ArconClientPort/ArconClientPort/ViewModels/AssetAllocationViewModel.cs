using ArconClientPort.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArconClientPort.ViewModels
{
    public class AssetAllocationViewModel
    {

        public List<AssetAllocationDataModel> AssetAllocationData { get; set; }

        public AssetAllocationViewModel()
        {
            AssetAllocationData = new List<AssetAllocationDataModel>()
            {
                // new AssetAllocationDataModel { AssetClass = "Portfolio Value as of "+DateSelected.DateRange.ToShortDateString(), Value = 2353935.05 },
                new AssetAllocationDataModel { AssetClass = "Large Equity Cap", MarketValue = 523850 },
                new AssetAllocationDataModel { AssetClass = "Intermediate Gov. Bond", MarketValue = 448160 },
                new AssetAllocationDataModel { AssetClass = "Muni National Long-Term Bond", MarketValue = 209640 },
                new AssetAllocationDataModel { AssetClass = "PA Muni Bond", MarketValue = 201990 },
                new AssetAllocationDataModel { AssetClass = "Short Term Corp. Bond", MarketValue = 185430 },
                new AssetAllocationDataModel { AssetClass = "Inflation Protected Bond", MarketValue = 143140 },
                new AssetAllocationDataModel { AssetClass = "Mid Cap Equity", MarketValue = 131080 },
                new AssetAllocationDataModel { AssetClass = "Intermediate Gov. & Corp. Bd", MarketValue = 128320 },
                new AssetAllocationDataModel { AssetClass = "International Bond", MarketValue = 122270 },
                new AssetAllocationDataModel { AssetClass = "Small Cap Equity", MarketValue = 94230 },

            };
        }
    }
}
