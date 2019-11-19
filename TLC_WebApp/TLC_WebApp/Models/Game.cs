using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLC_WebApp.Models
{
    public class Game
    {
        public String x = "X", o = "O", fill = "-";
        public byte choice;
        public String turn;
        public bool playable;
        public GameBoard gb = new GameBoard();
        public string gameBoard;
        private string ninetyDegrees;
        private string oneEighty;
        private string twoSeventy;
        public Game()
        {
            this.turn = x;
            this.playable = true;
        }
        public void flipBoard()
        {
            this.gameBoard =
                this.gb.dBGameBoard[0] + this.gb.dBGameBoard[1] + this.gb.dBGameBoard[2] +
                this.gb.dBGameBoard[3] + this.gb.dBGameBoard[4] + this.gb.dBGameBoard[5] +
                this.gb.dBGameBoard[6] + this.gb.dBGameBoard[7] + this.gb.dBGameBoard[8];
            oneEighty = gameBoard.ToCharArray().Reverse().ToString();
            this.ninetyDegrees = 
                this.gb.dBGameBoard[6]+this.gb.dBGameBoard[3] + this.gb.dBGameBoard[0]+
                this.gb.dBGameBoard[7] + this.gb.dBGameBoard[4] + this.gb.dBGameBoard[1]+
                this.gb.dBGameBoard[8] + this.gb.dBGameBoard[5] + this.gb.dBGameBoard[2];
            twoSeventy = ninetyDegrees.ToCharArray().Reverse().ToString();
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
