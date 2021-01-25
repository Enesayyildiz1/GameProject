using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.BusinessLogicLayer.Abstract
{
    public interface IPlayerService
    {
        public void Add(Player player,Game game);
        public void Delete(Player player, Game game);
        public void Update(Player player, Game game);
    }
}
