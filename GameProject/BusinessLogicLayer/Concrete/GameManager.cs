using System;
using System.Collections.Generic;
using System.Text;
using GameProject.BusinessLogicLayer.Abstract;
using GameProject.BusinessLogicLayer.CheckRealPerson;
using GameProject.Entities;

namespace GameProject.BusinessLogicLayer.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Added"+" "+game.FirstName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Updated");
        }
    }


}
