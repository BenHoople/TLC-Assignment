using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TLC_WebApp.Data;
using TLC_WebApp.Models;

namespace TLC_WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaeTacToeAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TaeTacToeAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GameBoards1
        [HttpGet]
        public IEnumerable<GameBoard> GetGameBoard()
        {
            return _context.GameBoard;
        }

        // GET: api/GameBoards1/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGameBoard([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gameBoard = await _context.GameBoard.FindAsync(id);

            if (gameBoard == null)
            {
                return NotFound();
            }

            return Ok(gameBoard);
        }

        // PUT: api/GameBoards1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameBoard([FromRoute] int id, [FromBody] GameBoard gameBoard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gameBoard.ID)
            {
                return BadRequest();
            }

            _context.Entry(gameBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameBoardExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GameBoards1
        [HttpPost]
        public async Task<IActionResult> PostGameBoard([FromBody] GameBoard gameBoard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GameBoard.Add(gameBoard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameBoard", new { id = gameBoard.ID }, gameBoard);
        }

        // DELETE: api/GameBoards1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameBoard([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gameBoard = await _context.GameBoard.FindAsync(id);
            if (gameBoard == null)
            {
                return NotFound();
            }

            _context.GameBoard.Remove(gameBoard);
            await _context.SaveChangesAsync();

            return Ok(gameBoard);
        }

        private bool GameBoardExists(int id)
        {
            return _context.GameBoard.Any(e => e.ID == id);
        }
    }
}