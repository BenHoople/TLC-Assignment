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
                //previous code that didn't work#2
                /*
                    game.UpDateAI(_context,gameBoards);
                    previous coe that didn't work #1
                    GameBoard update = new GameBoard();
                    game.gb = null; //release tracking of database object
                    foreach (Turn turn in game.turnTracker)
                    {
                        update = new GameBoard(gameBoards.Find(p => p.ID.Equals(turn.ID)));
                        update.UpdateAI(turn.position, game.learningRate);
                        _context.GameBoard.Update(update);
                        await _context.SaveChangesAsync();//needed coding stuff
                    }
                */
            }
            game.gb.ResetGameBoard();
            return RedirectToAction(nameof(Index));
        }

        private async void addToDatabase()
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
        /*
        // GET: GameBoards/Create
        public IActionResult Create()
        {
            return View();
        }
        */
        /*
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
       */
        //delete and edit code incase its needed
        /*
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
        */


        private bool GameBoardExists(int id)
        {
            return _context.GameBoard.Any(e => e.ID == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void TeachTheAI() 
        {
            int number = 100;
            //for x number of times, Play the Game
            for (int i = 0; i <= number; i++)
            {
                for (int x = 0; game.playable && x < 5; x++)
                {
                    //make random decision
                    if (game.playable)
                    {
                        game.makeRandomMove();

                        if (!gameBoards.Exists(p => p.Equals(game.gb)))
                        {
                            //addToDatabase();
                            game.gb.SendToDatabase();//here i will make all "-"'s = 0's so the math can begin
                            _context.Add(game.gb);//i'll add the game to the database here
                            _context.SaveChanges();//needed coding stuff
                            GetDataBaseData();
                        }
                        game.gb = gameBoards.Find(p => p.Equals(game.gb));
                    }
                    //AI choice (educated decision)
                    if (game.playable)
                    game.AIChoice();


                    game.gb.ResetGameBoard();
                }
                //learn
                foreach (GameBoard gameBoard in gameBoards)
                {
                    foreach (Turn turn in game.turnTracker)
                    {
                        if (turn.ID == gameBoard.ID)
                        {
                            gameBoard.UpdateAI(turn.position, game.learningRate);
                            _context.GameBoard.Update(gameBoard);
                            _context.SaveChanges();//needed coding stuff
                        }
                    }
                }
                game = new Game();
            }//repeat
        }
    }
}
