using Battleship.API.Enums;
using Battleship.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleship.API.Interfaces
{
    public interface IAttacker
    {
        AttackStatus Attack(Board board, int row, int column);
    }
}
