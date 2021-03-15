using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Yüklendi! --> " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi! --> " + game.GameName);
        }
   
        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi! --> " + game.GameName);
        }

     
    }
}
