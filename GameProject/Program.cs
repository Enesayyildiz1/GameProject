using GameProject.BusinessLogicLayer.Abstract;
using GameProject.BusinessLogicLayer.CheckRealPerson.Concrete;
using GameProject.BusinessLogicLayer.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager player = new PlayerManager(new PlayerCheckManager());
            IGameService game = new GameManager();
            Game game1 = new Game();
            game1.Id = 150;
            game1.FirstName = "Gta5";
            game1.Publisher = "RockStarGames";
            game1.UnitPrice = 250.0;
            game.Add(game1);
            
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Enes";
            player1.LastName = "Ayyıldız";
            player1.DateofBirth = new DateTime(2001, 6, 25);
            player1.NationalityId = "22222222222";

            player.Add(player1,game1);
       

            
            Console.Read();
            
        }
    }
}
