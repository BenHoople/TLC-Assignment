using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TLC_WebApp.Data;

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
        //for turn tracking and updating
        public List<Turn> turnTracker = new List<Turn>();
        public int learningRate = 0;

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
            string diagonalOne = gameBoard[0].ToString() + gameBoard[4].ToString() + gameBoard[8].ToString();
            string diagonalTwo = gameBoard[2].ToString() + gameBoard[4].ToString() + gameBoard[6].ToString();

            if((gameBoard[0]+gameBoard[1]+gameBoard[2]).Equals(winCondition)||
                    (gameBoard[3] + gameBoard[4] + gameBoard[5]).Equals(winCondition)||
                    (gameBoard[6] + gameBoard[7] + gameBoard[8]).Equals(winCondition)||
                    diagonalOne.Contains(winCondition) ||
                    diagonalTwo.Contains(winCondition) ||
                    (gameBoard[0] + gameBoard[3] + gameBoard[6]).Equals(winCondition) ||
                    (gameBoard[1] + gameBoard[4] + gameBoard[7]).Equals(winCondition) ||
                    (gameBoard[2] + gameBoard[5] + gameBoard[8]).Equals(winCondition))
            {
                whoGoesNext = "The Winner is " + turn + "! Try Again!";
                playable = false;
                Learn(turn);
                return true;
            }
            //checking to see if all spaces are taken by an X or an O
            if (CatsGame())
            {
                whoGoesNext = "Cats Game! Try Again!";
                playable = false;
                return true;
            }
            return false;
        }

        private bool CatsGame()
        {
            int numberOfTurns = 0;
            foreach(string letter in gameBoard)
            {
                if (letter.Equals(x)|| letter.Equals(o)) numberOfTurns += 1;
            }
            return numberOfTurns == 9;
        }

        private void Learn(string turn)
        {
            if(turn == x)
            {
                learningRate = -1;
            }
            else
            {
                learningRate = 1;
            }
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
            gb.SetAIGameBoard();
            //got this code from here: https://stackoverflow.com/questions/13755007/c-sharp-find-highest-array-value-and-index
            //this finds the highest number in the ai decision array
            int max = gb.aiDecisionBoard.Max();
            //add the selection to the turn tracker for later processing
            turnTracker.Add(new Turn(gb.ID, aIDecisionArray[Array.IndexOf(gb.aiDecisionBoard, max)]));
            //this selects the index of the decision array and feeds it to the string array here getting a string value and the location
            decision(aIDecisionArray[Array.IndexOf(gb.aiDecisionBoard,max)]);
        }

        public async void UpDateAI(ApplicationDbContext context, List<GameBoard> gameBoards)
        {
            foreach (GameBoard gameBoard in gameBoards)
            {
                foreach(Turn turn in turnTracker)
                {
                    if(turn.ID == gameBoard.ID)
                    {
                        gameBoard.UpdateAI(turn.position, learningRate);
                        context.GameBoard.Update(gameBoard);
                        await context.SaveChangesAsync();//needed coding stuff
                    }
                }
            }
        }
        public void makeRandomMove()
        {
            do
            {
                index = random.Next(9);//get a random index
            } while (gb.dBGameBoard[index].Equals(x)|| gb.dBGameBoard[index].Equals(o));//check if it equals an X || O
            decision(aIDecisionArray[index]);
            gb.dBGameBoard[index] = turn;
        }
    }
    
    //class
    //this was code to select a position at random,
    //im keeping it here because i might have to use it to train the AI
    //do
    //{
    //    index = random.Next(9);
    //} while (gb.dBGameBoard[index].Equals(x)|| gb.dBGameBoard[index].Equals(o));
    //decision(aIDecisionArray[index]);
    //gb.dBGameBoard[index] = turn;
}//namespace
