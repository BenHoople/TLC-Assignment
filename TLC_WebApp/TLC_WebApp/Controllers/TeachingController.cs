using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TLC_WebApp.Data;
using TLC_WebApp.Models;

namespace TLC_WebApp.Controllers
{
    public class TeachingController : Controller
    {


        private readonly ApplicationDbContext _context;

        private List<GameBoard> gameBoards = new List<GameBoard>();

        public TeachingController(ApplicationDbContext context)
        {
            _context = context;
            GetDataBaseData();
        }

        private void GetDataBaseData()
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

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void TeachTheAI(Game game)
        {
            int number = 100;
            //for x number of times, Play the Game
            for (int i = 0; i <= number; i++)
            {
                for (int x = 0; game.playable; x++)
                {
                    //make random decision
                    if (game.playable)
                    {
                        game.makeRandomMove();
                        if (!gameBoards.Contains(game.gb))
                        {
                            //addToDatabase();
                            game.gb.SendToDatabase();//here i will make all "-"'s = 0's so the math can begin
                            
                            _context.Add(game.gb);//i'll add the game to the database here
                            _context.SaveChanges();//needed coding stuff
                            GetDataBaseData();
                            gameBoards.Add(game.gb);
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