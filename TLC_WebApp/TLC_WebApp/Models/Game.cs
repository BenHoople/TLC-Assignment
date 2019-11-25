using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLC_WebApp.Models
{
    public class Game
    {
        //what i am currently using to indicate choices and to fill the board.
        public String x = "X", o = "O", fill = "-";
        //dynamic titles for the index
        public String turn, title = "Good Luck!", whoGoesNext;
        //checks to see if someone has won or not
        public bool playable;
        //the board we actually use to play the game
        public GameBoard gb = new GameBoard();
        //board flipping for easier win validation
        private string [] gameBoard;
        private string ninetyDegrees;
        //for the AI
        private int index;
        Random random = new Random();
        private string[] aIDecisionArray = { "TopLeft", "TopMiddle", "TopRight", "MiddleLeft", "MiddleMiddle", "MiddleRight", "BottomLeft", "BottomMiddle", "BottomRight" };
        //for turn tracking
        public List<Turn> turnTracker = new List<Turn>();

        //this will create a new game
        public Game()
        {
            turn = x;
            playable = true;
            whoGoesNext = "It's " + turn + "'s to Move!";
        }
        //i did more than neccessary here but i'm tired. this will create a string of the gb and flip it for easier
        //win validation and for DataBase validation.
        public void flipBoard()
        {
            gb.getGameBoard();
            gameBoard = gb.dBGameBoard;
            ninetyDegrees =
                (gb.dBGameBoard[6] + gb.dBGameBoard[3] + gb.dBGameBoard[0] +
                gb.dBGameBoard[7] + gb.dBGameBoard[4] + gb.dBGameBoard[1] +
                gb.dBGameBoard[8] + gb.dBGameBoard[5] + gb.dBGameBoard[2]);
        }
        //this will see if there is a winner
        public bool win()
        {
            string winCondition = turn + turn + turn;
            string diagonalOne = gameBoard[0] + gameBoard[4] + gameBoard[8];
            string diagonalTwo = gameBoard[2] + gameBoard[4] + gameBoard[6];

            if((gameBoard[0]+gameBoard[1]+gameBoard[2]).Equals(winCondition)||
                (gameBoard[3] + gameBoard[4] + gameBoard[5]).Equals(winCondition)||
                    (gameBoard[6] + gameBoard[7] + gameBoard[8]).Equals(winCondition)||
                    diagonalOne.Contains(winCondition) ||
                    diagonalTwo.Contains(winCondition) ||
                    (ninetyDegrees[0] + ninetyDegrees[1] + ninetyDegrees[2]).Equals(winCondition) ||
                    (ninetyDegrees[3] + ninetyDegrees[4] + ninetyDegrees[5]).Equals(winCondition) ||
                    (ninetyDegrees[6] + ninetyDegrees[7] + ninetyDegrees[8]).Equals(winCondition))
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
            if (turn == x)
            {
                turn = o;
            }
            else
            {
                turn = x;
            }
            whoGoesNext = "It's " + turn + "'s to Move!";
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
                title = "Thats Not a Valid Move!";
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
                    if (isMoveValid(gb.TopLeft))
                    {
                        gb.TopLeft = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                case "TopMiddle":
                    if (isMoveValid(gb.TopMiddle))
                    {
                        gb.TopMiddle = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                case "TopRight":
                    if (isMoveValid(gb.TopRight))
                    {
                        gb.TopRight = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                case "MiddleLeft":
                    if (isMoveValid(gb.MiddleLeft))
                    {
                        gb.MiddleLeft = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                case "MiddleMiddle":
                    if (isMoveValid(gb.MiddleMiddle))
                    {
                        gb.MiddleMiddle = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                case "MiddleRight":
                    if (isMoveValid(gb.MiddleRight))
                    {
                        gb.MiddleRight = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }

                    break;
                case "BottomLeft":
                    if (isMoveValid(gb.BottomLeft))
                    {
                        gb.BottomLeft = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                case "BottomMiddle":
                    if (isMoveValid(gb.BottomMiddle))
                    {
                        gb.BottomMiddle = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                case "BottomRight":
                    if (isMoveValid(gb.BottomRight))
                    {
                        gb.BottomRight = turn;
                        flipBoard();
                        if (!win())
                        {
                            move();
                        }
                    }
                    break;
                default:
                    break;
            }//end switch
            if (playable == false)
            {
                title = "Please Press New Game!";
            }
        }//end of decision


        public void AIChoice()
        {
            do
            {
                index = random.Next(9);
            } while (gb.dBGameBoard[index].Equals(x)|| gb.dBGameBoard[index].Equals(o));
            decision(aIDecisionArray[index]);
            //gb.dBGameBoard[index] = turn;
            gb.setGameBoard();
            flipBoard();
            if (!win())
            {
                move();
            }
        }


    }
}
