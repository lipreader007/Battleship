using Battleship.API.Implementations;
using System;
using Xunit;

namespace Battleship.Test
{
    public class BoardTest
    {
        //seed
        [Theory]
        [InlineData(10,10)]
        [InlineData(20,20)]
        [InlineData(30,30)]

        public void ShouldReturnValidBoard_WhenBoardCreated(int rows, int columns)
        {
            //init board
            var boardCreator = new BoardCreator();

            //act
            var board = boardCreator.CreateBoard(rows, columns);

            //assert
            Assert.Equal(rows * columns, board.BoardCellStatuses.Length);

        }
    }
}
