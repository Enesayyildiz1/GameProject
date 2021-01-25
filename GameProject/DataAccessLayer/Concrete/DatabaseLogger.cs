using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccessLayer
{
    class DatabaseLogger : ILoggerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Added to database"+player.FirstName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Deleted to database" + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Updated to database" + player.FirstName);
        }
    }
}
