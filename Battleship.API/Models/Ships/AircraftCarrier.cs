using System;
using Battleship.API.Enums;

namespace Battleship.API.Models.Ships
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier()
        {
            Size = 5;
            ShipType = ShipType.AircraftCarrier;
        }
    }
}
