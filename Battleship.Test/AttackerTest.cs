using Battleship.API.Enums;
using Battleship.API.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Battleship.Test
{
    public class AttackerTest
    {
        //seed
        [Theory]
        [InlineData(10, 10, 0, 0, 0, 0, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 1, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 2, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 3, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 4, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 5, 5, ShipType.AircraftCarrier, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 5, ShipType.AircraftCarrier, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 3, 8, ShipType.AircraftCarrier, BoardCellStatus.Miss)]

        public void ShouldReturnRightAttackStatus_WhenAttackLaunched(
            int boardRows, int boardColumns,
            int placementRow, int placementColumn,
            int attackRow, int attackColumn,
            ShipType shipType, BoardCellStatus boardCellStatus)
        {
            //init board
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);
            //init ship
            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);
            //place the ship on the board
            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, placementRow, placementColumn);

            //act
            var attacker = new Attacker();
            attacker.Attack(board, attackRow, attackColumn);

            //assert

            Assert.True(board.BoardCellStatuses[attackRow, attackColumn] == boardCellStatus);

        }
    }
}
