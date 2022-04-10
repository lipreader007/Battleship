using Battleship.API.Enums;
using Battleship.API.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Battleship.Test
{
    public class ShipPlacementTest
    {
        //seed
        [Theory]
        [InlineData(10,10,0,0,ShipType.AircraftCarrier)]
        [InlineData(10,10,0,6,ShipType.Destroyer)]
        public void ShouldPlaceAShip_WhenCorrectPositionProvided(int boardRows, int boardColumns, int placementRow, int placementColumn, ShipType shipType)
        {
            //init
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            //act
            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, placementRow, placementColumn);

            //assert
            Assert.True(board.BoardCellStatuses[placementRow, placementColumn] == BoardCellStatus.Occupied &&
                board.BoardCellStatuses[placementRow, placementColumn + ship.Size - 1] == BoardCellStatus.Occupied);
        }
    }
}
