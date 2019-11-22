﻿using System;
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
        public RedirectToActionResult Clicked(String position)
        {
            if (game.playable)
            {
                game.decision(position);
            }
            if (game.playable)
            {
                game.AIChoice();
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
