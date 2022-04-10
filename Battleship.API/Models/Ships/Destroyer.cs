using System;
using Battleship.API.Enums;
namespace Battleship.API.Models.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Size = 2;
            ShipType = ShipType.Destroyer;
        }
    }
}
