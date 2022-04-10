using Battleship.API.Enums;
using Battleship.API.Implementations;
using System;
using Xunit;

namespace Battleship.Test
{
    public class ShipTest
    {
        //seed
        [Theory]
        [InlineData(ShipType.AircraftCarrier)]
        [InlineData(ShipType.Destroyer)]
        public void ShouldReturnShip_WhenShipCreated(ShipType shipType)
        {
            //init ship
            var shipCreator = new ShipCreator();

            //act
            var ship = shipCreator.CreateShip(shipType);

            //assert
            Assert.NotNull(ship);
        }
    }
}
