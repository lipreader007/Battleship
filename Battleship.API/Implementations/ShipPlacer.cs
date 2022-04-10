using System;
using Battleship.API.Enums;
using Battleship.API.Interfaces;
using Battleship.API.Models;

namespace Battleship.API.Implementations
{
    public class ShipPlacer : IShipPlacer
    {
        public void AddShipToBoard(Ship ship, Board board, int row, int column)
        {
            Validate(ship, board, row, column);
            for (int i = 0; i < ship.Size; i++)
            {
                board.BoardCellStatuses[row, column + i] = BoardCellStatus.Occupied;
                board.OccupationCount++;
            }
        }

        private void Validate(Ship ship, Board board, int row, int column)
        {
            var errorMessage = "Ship's placement position is out of bounds";
            
            if (row > board.Rows)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }
            if (column > board.Columns)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }

            for (int c=0; c < ship.Size; c++)
            {
                if (column + c > board.Columns)
                {
                    throw new IndexOutOfRangeException(errorMessage);
                }
            }
        }
    }
}
