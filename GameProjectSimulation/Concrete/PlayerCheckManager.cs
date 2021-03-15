using GameProjectSimulation.Abstract;

namespace GameProjectSimulation.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool RealPlayer(Player player)
        {
            if (player.FirstName == "Yeşim" && player.LastName == "Doğan" && player.NationalityId == 22222222222 && player.BirthYear == 2000)
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
