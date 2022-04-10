using Battleship.API.Models;
using System;
namespace Battleship.API.Interfaces
{
    public interface IShipPlacer
    {
        void AddShipToBoard(Ship ship, Board board, int row, int column);
    }
}
