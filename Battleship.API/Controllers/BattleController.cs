using Battleship.API.Implementations;
using Battleship.API.Interfaces;
using Battleship.API.Models;
using Battleship.API.Enums;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Battleship.API.Controllers
{
    [Route("api/v1/battleship")]
    [ApiController]
    public class BattleController : ControllerBase
    {
        [Route("create")]
        [HttpPost]
        public ActionResult<IBoardCreator> CreateBoard([FromBody] BoardParameters newBoard)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(newBoard.Rows, newBoard.Columns);

                return Ok("Create board succeed with row is: " + board.Rows + " column is: " + board.Columns);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed");
            }
        }

        [Route("place")]
        [HttpPost]
        public ActionResult PlaceShip([FromBody] PlaceShipParameters body)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(body.boardRows, body.boardColumns);

                var shipCreator = new ShipCreator();
                var ship = shipCreator.CreateShip(body.shipType);

                var shipPlacer = new ShipPlacer();
                shipPlacer.AddShipToBoard(ship, board, body.placementRow, body.placementColumn);

                return Ok("Place ship on the board succeed at placement Row: " + body.boardRows + " board Columns: " + body.boardColumns);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("attack")]
        [HttpPost]
        public ActionResult Attacker([FromBody] AttackParameters attack)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(attack.boardRows, attack.boardColumns);

                var shipCreator = new ShipCreator();
                var ship = shipCreator.CreateShip(attack.shipType);

                var shipPlacer = new ShipPlacer();
                shipPlacer.AddShipToBoard(ship, board, attack.placementRow, attack.placementColumn);

                var attacker = new Attacker();
                var result = attacker.Attack(board, attack.attackRow, attack.attackColumn);

                return Ok(result == AttackStatus.Hit ? "Hit" : "Miss");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
