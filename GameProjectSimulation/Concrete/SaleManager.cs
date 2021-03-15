using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Player player, Game game)
        {
         
            Console.WriteLine("Oyun, "+ player.FirstName + " " + player.LastName + " İsimli Oyuncuya " + game.GamePrice + " Fiyatına Satıldı.");

        }
        public void CampaignSale(Player player, Game game, Campaign campaign)
        {

            int price = game.GamePrice;
            if (campaign.Discount > 0)
            {
                 price = game.GamePrice - campaign.Discount;
            }        

            Console.WriteLine("Oyun, " + player.FirstName + " " + player.LastName + " İsimli Oyuncuya " + 
                              campaign.CampaignName + " Adlı Kampanyanın İndirimi Uygulanarak " + price + " Fiyatına Satıldı.");


        }

       
    }
}
