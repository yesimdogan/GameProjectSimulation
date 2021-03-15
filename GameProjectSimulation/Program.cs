using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;
using System;

namespace GameProjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());

            Player player1 = new Player()
            {
                PlayerId = 4,
                FirstName = "Yeşim",
                LastName = "Doğan",
                BirthYear = 2000,
                NationalityId = 22222222222,

            };

            playerManager.Add(player1);
            playerManager.Delete(player1);
            playerManager.Update(player1);

            Console.WriteLine(Environment.NewLine);
            
            Game game = new Game();
            game.GameName = "League of Legends";
            game.GamePrice = 120;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            Console.WriteLine(Environment.NewLine);

            Campaign campaign = new Campaign
            {
                CampaignName = "Bahar İndirimi",
                Discount = 70

            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);

            Console.WriteLine(Environment.NewLine);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(player1, game);
            saleManager.CampaignSale(player1, game, campaign);
        

            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("Oyuncu : " + player1.FirstName + " " + player1.LastName + "\n" + "Oyun Adı ve Fiyatı: " + game.GameName + " --> " + game.GamePrice +"TL"+ "\n" + 
                                "Kampanya Adı ve Uygulanacak İndirim : " + campaign.CampaignName + "-->" + campaign.Discount + "TL" );




           
            Console.ReadKey();
            
        }
    }
}
