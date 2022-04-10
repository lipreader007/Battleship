using Battleship.API.Enums;
using Battleship.API.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Battleship.Test
{
    public class GameStatusTest
    {
        [Fact]
        public void ShouldReturnLostGameStatus_WhenShipSunk()
        {
            //init
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(10, 10);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(ShipType.AircraftCarrier);

            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, 0, 0);

            //act
            var attacker = new Attacker();
            attacker.Attack(board, 0, 0);
            attacker.Attack(board, 0, 1);
            attacker.Attack(board, 0, 2);
            attacker.Attack(board, 0, 3);
            attacker.Attack(board, 0, 4);

            //assert
            Assert.True(board.HasLost);
        }

        [Fact]
        public void ShouldNotReturnLostGameStatusTrue_WhenShipNotSunk()
        {
            //init
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(10, 10);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(ShipType.AircraftCarrier);

            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, 0, 0);

            //act
            var attacker = new Attacker();
            attacker.Attack(board, 0, 0);
            attacker.Attack(board, 0, 1);

            //assert
            Assert.False(board.HasLost);
        }
    }
}
