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

        private List<GameBoard> gameBoards = new List<GameBoard>();

        public GameBoardsController(ApplicationDbContext context)
        {
            _context = context;
            GetDataBaseData();
        }

        private async void GetDataBaseData()
        {
            try
            {
                gameBoards = _context.GameBoard.ToList();
            }
            catch (Exception e)
            {
                RedirectToAction(nameof(Index));
            }
        }

        public static Game game = new Game();

        public RedirectToActionResult NewGame()
        {
            game = new Game();
            return RedirectToAction(nameof(Index));
        }

        // GET: GameBoards
        public async Task<IActionResult> Index()
        {
            return View(game);
        }
        //verify position of clicked button.
        public async Task<IActionResult> Clicked(String position)
        {
            //player choice
            if (game.playable)//make sure game is playable
            {
                game.decision(position);//make the move
                
                if (!gameBoards.Contains(game.gb))//check to see if the gameboard exists in the database
                {//here i've determined it not to be in the database so i have to add it.
                    addToDatabase();
                    GetDataBaseData();//by updating the gameBoards list i'll be able to get the gameboard ID for later updating
                }
                    //yes im searching the list twice in a row which seems redundant but not sure how else to do it
                    //this should change the game.gb board to numbers for ai searching and give it an ID to put into the Turns list
                    game.gb = gameBoards.Find(p => p.Equals(game.gb));
            }
            //AI choice
            if (game.playable)//game should be playable unless there are no turns to make or if x won
            {
                game.AIChoice(); //choose the highest number or go for broke
            }
            //learn
            if (!game.playable)
            {
                foreach (GameBoard gameBoard in gameBoards)
                {
                    foreach (Turn turn in game.turnTracker)
                    {
                        if (turn.ID == gameBoard.ID)
                        {
                            gameBoard.UpdateAI(turn.position, game.learningRate);
                            _context.GameBoard.Update(gameBoard);
                            await _context.SaveChangesAsync();//needed coding stuff
                        }
                    }
                }

            }
            game.gb.ResetGameBoard();
            return View(nameof(Index));
        }


        private void addToDatabase()
        {
            game.gb.SendToDatabase();//here i will make all "-"'s = 0's so the math can begin
            _context.Add(game.gb);//i'll add the game to the database here
            _context.SaveChanges();//needed coding stuff
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


        private bool GameBoardExists(int id)
        {
            return _context.GameBoard.Any(e => e.ID == id);
        }

        public async Task<IActionResult> TeachTheAI() {
            TeachingController teach = new TeachingController(_context);
            teach.TeachTheAI(game);
            return View(nameof(Index));
        }
    }
}
