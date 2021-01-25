using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccessLayer
{
    interface ILoggerService
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
