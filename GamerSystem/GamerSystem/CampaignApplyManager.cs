using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    public class CampaignApplyManager : ICampaignApplyService
    {
        public bool CampaignApply(Sales sales)
        {
            if (sales.Campaign==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
