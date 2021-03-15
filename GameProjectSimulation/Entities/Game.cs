using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    public class Game : IEntity
    {
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        
    }
}
