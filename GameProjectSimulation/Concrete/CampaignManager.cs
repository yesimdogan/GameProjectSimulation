using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {          
            Console.WriteLine("Kampanya Yüklendi! --> " + campaign.CampaignName + ":" + campaign.Discount + "TL");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi! --> " + campaign.CampaignName + ":" + campaign.Discount + "TL");
        }

    }
}
