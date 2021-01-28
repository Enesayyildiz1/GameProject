using GameProject.BusinessLogicLayer.Abstract;
using GameProject.BusinessLogicLayer.CheckRealPerson;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.BusinessLogicLayer.Concrete
{
    class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public override void Add(Player player,Game game)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {

                base.Add(player,game);
            } 

            else
            {
                throw new Exception("Not a valid person");
            }
        }

        
    }
}
