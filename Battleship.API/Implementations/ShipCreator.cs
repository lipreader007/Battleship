using System;
using Battleship.API.Enums;
using Battleship.API.Interfaces;
using Battleship.API.Models;
using Battleship.API.Models.Ships;

namespace Battleship.API.Implementations
{
    public class ShipCreator : IShipCreator
    {
        public Ship CreateShip(ShipType shipType)
        {
            try
            {
                switch (shipType)
                {
                    case ShipType.AircraftCarrier:
                        return new AircraftCarrier();
                    case ShipType.Destroyer:
                        return new Destroyer();
                    default:
                        return new AircraftCarrier();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not initialize ship: {ex.Message}");
            }
        }
    }
}
