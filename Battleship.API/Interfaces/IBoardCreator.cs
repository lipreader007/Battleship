using System;
using Battleship.API.Models;

namespace Battleship.API.Interfaces
{
    public interface IBoardCreator
    {
        Board CreateBoard(int rows, int columns);
    }
}
