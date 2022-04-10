using System;
using Battleship.API.Enums;
using Battleship.API.Interfaces;
using Battleship.API.Models;

namespace Battleship.API.Implementations
{
    public class BoardCreator : IBoardCreator
    {
        public Board CreateBoard(int rows, int columns)
        {
            try
            {
                BoardCellStatus[,] statusArray = new BoardCellStatus[rows, columns];
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        statusArray[row, column] = BoardCellStatus.Unoccupied;
                    }
                }
                
                return new Board
                {
                    BoardCellStatuses = statusArray,
                    Rows = rows,
                    Columns = columns
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while initializing board : {ex.Message}");
            }
        }

        public object CreateBoard(object boardRows, object boardColumns)
        {
            throw new NotImplementedException();
        }
    }
}
