using Battleship.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleship.API.Models
{
    public abstract class Ship
    {
        public ShipType ShipType { get; set; }
        public int Size { get; set; }
    }
}
