using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamePurchaseManager : IGamePurchaseService
    {
       

        public void Purchase(Gamer gamer, Games games, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + games.Name + " oyununu " + campaign.CampaingName + " kampanyası ile" +
                " başarıyla satın aldı.");
        }
    }
}
