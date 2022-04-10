using Battleship.API.Enums;
using Battleship.API.Models;
using System;

namespace Battleship.API.Interfaces
{
    public interface IShipCreator
    {
        Ship CreateShip(ShipType shipType);
    }
}
