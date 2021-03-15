using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.RealPlayer(player)==true)
            {
                Console.WriteLine("Oyuncu Yüklendi! --> " + player.PlayerId + " : " + player.FirstName + " " + player.LastName);
            }
            else
            {
                Console.WriteLine("Oyuncu Yüklenemedi! --> " + player.PlayerId + " : " + player.FirstName + " " + player.LastName);
            }
        }


        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi! --> " + player.PlayerId + " : " + player.FirstName + " " + player.LastName);
        }


        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi! --> " + player.PlayerId + " : " + player.FirstName + " " + player.LastName);
        }

    }
}
