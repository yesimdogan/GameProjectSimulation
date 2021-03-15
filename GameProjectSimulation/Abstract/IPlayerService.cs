using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);

    }
}
