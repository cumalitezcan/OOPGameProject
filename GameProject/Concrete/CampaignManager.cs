using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Cadd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName+" kampanyası eklendi");
        }

        public void Cdelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName+" kampanyası silindi");
        }

        public void Cupdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName+" kampanyasının bilgileri güncellendi");
        }
    }
}
