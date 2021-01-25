using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.BusinessLogicLayer.CheckRealPerson.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            if (player.FirstName!= null && player.LastName != null && player.Id != null && player.DateofBirth.Year > 1900 && player.NationalityId.Length == 11)
            {
                return true;
            }
            return false;
        }
    }
}
