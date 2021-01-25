using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set ; }
        public string FirstName { get; set ; }
        public string  Publisher { get; set; }
        public double UnitPrice { get; set; }
    }
}
