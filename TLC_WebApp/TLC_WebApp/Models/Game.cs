using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLC_WebApp.Models
{
    public class Game
    {
        public String[] gameBoard = new String[9];
        public String x = "X", o = "O", fill = "-";
        public byte choice;
        public String turn;
        public bool playable;
        public GameBoard gb = new GameBoard();

        public Game()
        {
            this.turn = x;
            this.playable = true;
        }
        public void move()
        {
            if (this.turn == x)
            {
                this.turn = o;
            }
            else
            {
                this.turn = x;
            }
        }
        private byte takeInput()
        {
            return 1;
        }

        public bool isPlayable()
        {
            return playable;
        }

        public bool checkBoard(String[] DBGameBoard)
        {
            return gameBoard.Equals(DBGameBoard);
        }
        public bool isMoveValid(String position)
        {
            if (position.Equals(x) || position.Equals(o))
            {
                return false;
            }
            else return true;
        }
    }
}
