using GameProject.BusinessLogicLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.BusinessLogicLayer.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi"); 
        }
    }
}
