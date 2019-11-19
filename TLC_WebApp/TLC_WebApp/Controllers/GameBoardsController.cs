using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TLC_WebApp.Data;
using TLC_WebApp.Models;

namespace TLC_WebApp.Controllers
{
    public class GameBoardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GameBoardsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public static Game game = new Game();
        public static string winner = "No Winner Yet";

        // GET: GameBoards
        public async Task<IActionResult> Index()
        {
            return View(game);
        }
        //verify position of clicked button.
        public RedirectToActionResult Clicked(String position)
        {
            switch (position)
            {
                case "TopLeft":
                    if (game.isMoveValid(game.gb.TopLeft))
                    {
                        game.gb.TopLeft = game.turn;
                    }
                    else
                    {
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                case "TopMiddle":
                    if (game.isMoveValid(game.gb.TopMiddle))
                    {
                        game.gb.TopMiddle = game.turn;
                    }
                    else
                    {
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                case "TopRight":
                    if(game.isMoveValid(game.gb.TopRight)){
                        game.gb.TopRight = game.turn;
                    }else{
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                case "MiddleLeft":
                    if(game.isMoveValid(game.gb.MiddleLeft)){
                    game.gb.MiddleLeft = game.turn;
                        }else{
                        winner = "Thats Not a Valid Move!";
                        }
                    break;
                case "MiddleMiddle":
                    if(game.isMoveValid(game.gb.MiddleMiddle)){
                        game.gb.MiddleMiddle = game.turn;
                    }else{
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                case "MiddleRight":
                    if (game.isMoveValid(game.gb.MiddleRight))
                    {
                        game.gb.MiddleRight = game.turn;
                    }
                    else
                    {
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                case "BottomLeft":
                    if (game.isMoveValid(game.gb.BottomLeft))
                    {
                        game.gb.BottomLeft = game.turn;
                    }
                    else
                    {
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                case "BottomMiddle":
                    if (game.isMoveValid(game.gb.BottomMiddle))
                    {
                        game.gb.BottomMiddle = game.turn;
                    }
                    else
                    {
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                case "BottomRight":
                    if (game.isMoveValid(game.gb.BottomRight))
                    {
                        game.gb.BottomRight = game.turn;
                    }
                    else
                    {
                        winner = "Thats Not a Valid Move!";
                    }
                    break;
                default:
                    break;
            }
            game.flipBoard();
            if (game.win())
            {
                winner = "The Winner is " + game.turn + "!";
            }
            return RedirectToAction(nameof(Index));
        }
            // GET: GameBoards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameBoard = await _context.GameBoard
                .FirstOrDefaultAsync(m => m.ID == id);
            if (gameBoard == null)
            {
                return NotFound();
            }

            return View(gameBoard);
        }

        // GET: GameBoards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameBoards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TopLeft,TopMiddle,TopRight,MiddleLeft,MiddleMiddle,MiddleRight,BottomLeft,BottomMiddle,BottomRight")] GameBoard gameBoard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameBoard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameBoard);
        }

        // GET: GameBoards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameBoard = await _context.GameBoard.FindAsync(id);
            if (gameBoard == null)
            {
                return NotFound();
            }
            return View(gameBoard);
        }

        // POST: GameBoards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TopLeft,TopMiddle,TopRight,MiddleLeft,MiddleMiddle,MiddleRight,BottomLeft,BottomMiddle,BottomRight")] GameBoard gameBoard)
        {
            if (id != gameBoard.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameBoard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameBoardExists(gameBoard.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gameBoard);
        }

        // GET: GameBoards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameBoard = await _context.GameBoard
                .FirstOrDefaultAsync(m => m.ID == id);
            if (gameBoard == null)
            {
                return NotFound();
            }

            return View(gameBoard);
        }

        // POST: GameBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameBoard = await _context.GameBoard.FindAsync(id);
            _context.GameBoard.Remove(gameBoard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameBoardExists(int id)
        {
            return _context.GameBoard.Any(e => e.ID == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> onclick()
        {

            GameBoard gb = new GameBoard();
            gb.TopLeft = "X";
            return View(); ;
        }
    }
}
