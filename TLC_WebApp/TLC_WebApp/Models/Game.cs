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
        public String turn, title = "Good Luck!", whoGoesNext;
        public bool playable;
        public GameBoard gb = new GameBoard();
        public string gameBoard;
        private string ninetyDegrees;
        private string oneEighty;
        private string twoSeventy;
        //this will create a new game
        public Game()
        {
            this.turn = x;
            this.playable = true;
            this.whoGoesNext = "It's " + turn + "'s to Move!";
        }
        //i did more than neccessary here but i'm tired. this will create a string of the gb and flip it for easier
        //win validation and for DataBase validation.
        public void flipBoard()
        {
            this.gb.setGameBoard();
            this.gameBoard =
                this.gb.dBGameBoard[0] + this.gb.dBGameBoard[1] + this.gb.dBGameBoard[2] +
                this.gb.dBGameBoard[3] + this.gb.dBGameBoard[4] + this.gb.dBGameBoard[5] +
                this.gb.dBGameBoard[6] + this.gb.dBGameBoard[7] + this.gb.dBGameBoard[8];
            oneEighty = this.gameBoard.ToCharArray().Reverse().ToString();
            this.ninetyDegrees = 
                this.gb.dBGameBoard[6]+this.gb.dBGameBoard[3] + this.gb.dBGameBoard[0]+
                this.gb.dBGameBoard[7] + this.gb.dBGameBoard[4] + this.gb.dBGameBoard[1]+
                this.gb.dBGameBoard[8] + this.gb.dBGameBoard[5] + this.gb.dBGameBoard[2];
            twoSeventy = ninetyDegrees.ToCharArray().Reverse().ToString();
        }
        //this will see if there is a winner
        public bool win()
        {
            string winCondition = turn + turn + turn;
            string diagonalOne =
                this.gb.dBGameBoard[0] + this.gb.dBGameBoard[4] + this.gb.dBGameBoard[8];
            string diagonalTwo =
                this.gb.dBGameBoard[2] + this.gb.dBGameBoard[4] + this.gb.dBGameBoard[6];

            if (gameBoard.Contains(winCondition) ||
                ninetyDegrees.Contains(winCondition) ||
                diagonalOne.Contains(winCondition) ||
                diagonalTwo.Contains(winCondition))
            {
                title = "The Winner is " + turn + "!";
                whoGoesNext = "Great Game!";
                playable = false;
                return true;
            }
            else return false;
        }
        //this will change who's turn it is!
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
            this.whoGoesNext = "It's " + turn + "'s to Move!";
        }
        //not sure if i'll still use this or not, it was for debuggin but i may repurpose later for DB
        public bool checkBoard(String[] DBGameBoard)
        {
            return gameBoard.Equals(DBGameBoard);
        }
        //checks the square to see if its been used already
        public bool isMoveValid(String position)
        {
            if (position.Equals(x) || position.Equals(o))
            {
                this.title = "Thats Not a Valid Move!";
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
