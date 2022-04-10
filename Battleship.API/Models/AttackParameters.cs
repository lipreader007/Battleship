using Battleship.API.Enums;
using System;

namespace Battleship.API.Models
{
    public class AttackParameters
    {
        public int boardRows { get; set; }
        public int boardColumns { get; set; }
        public int placementRow { get; set; }
        public int placementColumn { get; set; }
        public int attackRow { get; set; }
        public int attackColumn { get; set; }
        public ShipType shipType { get; set; }
        public BoardCellStatus boardCellStatus { get; set; }
    }
}
