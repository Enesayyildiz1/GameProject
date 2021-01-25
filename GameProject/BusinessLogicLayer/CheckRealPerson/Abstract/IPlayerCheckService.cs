using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.BusinessLogicLayer.CheckRealPerson
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
