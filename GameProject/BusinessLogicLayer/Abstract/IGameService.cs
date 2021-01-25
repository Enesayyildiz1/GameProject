using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.BusinessLogicLayer.Abstract
{
    interface IGameService
    {
        public void Add(Game game);
        public void Delete(Game  game);
        public void Update(Game game);
    }
}
