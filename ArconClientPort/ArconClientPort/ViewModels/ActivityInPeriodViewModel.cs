using ArconClientPort.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArconClientPort.ViewModels
{
    public class ActivityInPeriodViewModel
    {
        public List<ActivityInPeriodDataModel> Data { get; set; }
        

        public ActivityInPeriodViewModel()
        {
            
            Data = new List<ActivityInPeriodDataModel>()
            {
                // new ActivityInPeriodDataModel { Activity = "Portfolio Value as of "+DateSelected.DateRange.ToShortDateString(), Value = 2353935.05 },
                new ActivityInPeriodDataModel { Activity = "Portfolio Value as of "+DateSelected.datechosen.ToShortDateString(), Value = 2353935.05 },
                new ActivityInPeriodDataModel { Activity = "Net Contribution", Value = 0.00 },
                new ActivityInPeriodDataModel { Activity = "Realized Gains", Value = 0.00 },
                new ActivityInPeriodDataModel { Activity = "Unrealized Gains", Value = 19453.07 },
                new ActivityInPeriodDataModel { Activity = "Interest", Value = 5.09 },
                new ActivityInPeriodDataModel { Activity = "Dividends", Value = 8025.27 },
                new ActivityInPeriodDataModel { Activity = "Portfolio Value as of  "+DateTime.Now.AddMonths(-3).ToShortDateString(), Value = 2334481.98 }
                //+DateSelected.DateRange.AddMonths(-3).ToShortDateString()

            };
        }
    }
}
