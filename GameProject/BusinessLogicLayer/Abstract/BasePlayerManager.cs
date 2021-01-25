using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.BusinessLogicLayer.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {

        public virtual void Add(Player player,Game game)
        {
            Console.WriteLine("Added to Database:"+player.FirstName);
            Console.WriteLine(player.FirstName+" bought "+game .FirstName );
        }

        

        public void Delete(Player player, Game game)
        {
            throw new NotImplementedException();
        }

        

        public void Update(Player player, Game game)
        {
            throw new NotImplementedException();
        }

        
    }
}
