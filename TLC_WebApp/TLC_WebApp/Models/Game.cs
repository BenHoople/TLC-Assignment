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
            oneEighty = ReverseString(gameBoard);
            this.ninetyDegrees =
                this.gb.dBGameBoard[6] + this.gb.dBGameBoard[3] + this.gb.dBGameBoard[0] +
                this.gb.dBGameBoard[7] + this.gb.dBGameBoard[4] + this.gb.dBGameBoard[1] +
                this.gb.dBGameBoard[8] + this.gb.dBGameBoard[5] + this.gb.dBGameBoard[2];
            twoSeventy = ReverseString(ninetyDegrees);
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
        //taken from online at: https://www.dotnetperls.com/reverse-string
        //i could have done it myself but it was already there
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public void decision(string position)
        {
            switch (position)
            {
                case "TopLeft":
                    if (this.isMoveValid(this.gb.TopLeft))
                    {
                        this.gb.TopLeft = this.turn;
                    }
                    break;
                case "TopMiddle":
                    if (this.isMoveValid(this.gb.TopMiddle))
                    {
                        this.gb.TopMiddle = this.turn;
                    }
                    break;
                case "TopRight":
                    if (this.isMoveValid(this.gb.TopRight))
                    {
                        this.gb.TopRight = this.turn;
                    }
                    break;
                case "MiddleLeft":
                    if (this.isMoveValid(this.gb.MiddleLeft))
                    {
                        this.gb.MiddleLeft = this.turn;
                    }
                    break;
                case "MiddleMiddle":
                    if (this.isMoveValid(this.gb.MiddleMiddle))
                    {
                        this.gb.MiddleMiddle = this.turn;
                    }
                    break;
                case "MiddleRight":
                    if (this.isMoveValid(this.gb.MiddleRight))
                    {
                        this.gb.MiddleRight = this.turn;
                    }

                    break;
                case "BottomLeft":
                    if (this.isMoveValid(this.gb.BottomLeft))
                    {
                        this.gb.BottomLeft = this.turn;
                    }
                    break;
                case "BottomMiddle":
                    if (this.isMoveValid(this.gb.BottomMiddle))
                    {
                        this.gb.BottomMiddle = this.turn;
                    }
                    break;
                case "BottomRight":
                    if (this.isMoveValid(this.gb.BottomRight))
                    {
                        this.gb.BottomRight = this.turn;
                    }
                    break;
                default:
                    break;
            }//end switch
            if (this.isMoveValid(position))
            {

                this.flipBoard();
                if (!this.win())
                {
                    this.move();
                }

            }
            else
            {
                title = "Please Press New Game!";
            }
        }//end of decision
    }
}
