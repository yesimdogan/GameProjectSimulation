using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    interface ISaleService
    {
        void Sale(Player player, Game game);
        void CampaignSale(Player player, Game game, Campaign campaign);
    }
}
