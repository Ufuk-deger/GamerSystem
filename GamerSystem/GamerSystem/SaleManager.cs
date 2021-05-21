using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    public class SaleManager : ISaleService
    {
        ICampaignApplyService _campaignApplyService;

        public SaleManager(ICampaignApplyService campaignApplyService)
        {
            _campaignApplyService = campaignApplyService;
        }

        public void Return(Sales sales)
        {
            Console.WriteLine("İade Yapıldı");
        }

        public void Sale(Sales sales)
        {
            if (_campaignApplyService.CampaignApply(sales)==true)
            {
                Console.WriteLine("Kampanyalı Satış Yapıldı");
            }
            else if (_campaignApplyService.CampaignApply(sales) == false)
            {
                Console.WriteLine("Satış Yapıldı");
            }
            
        }
    }
}
