using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TLC_WebApp.Models
{
    public class GameBoard
    {
        public virtual int ID { get; set; }
        public virtual String TopLeft { get; set; } = "-";
        public virtual String TopMiddle { get; set; } = "-";
        public virtual String TopRight { get; set; } = "-";
        public virtual String MiddleLeft { get; set; } = "-";
        public virtual String MiddleMiddle { get; set; } = "-";
        public virtual String MiddleRight { get; set; } = "-";
        public virtual String BottomLeft { get; set; } = "-";
        public virtual String BottomMiddle { get; set; } = "-";
        public virtual String BottomRight { get; set; } = "-";
        [NotMapped]
        public string[] dBGameBoard { get; set; } = new string[9];
        [NotMapped]
        public int[] aiDecisionBoard { get; set; } = new int[9];

        public GameBoard() {
            getGameBoard();
        }

        public GameBoard(String TopLeft,String TopMiddle,String TopRight,String MiddleLeft,
            String MiddleMiddle,String MiddleRight,String BottomLeft,String BottomMiddle,String BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopMiddle = TopMiddle;
            this.TopRight = TopRight;
            this.MiddleLeft = MiddleLeft;
            this.MiddleMiddle = MiddleMiddle;
            this.MiddleRight = MiddleRight;
            this.BottomLeft = BottomLeft;
            this.BottomMiddle = BottomMiddle;
            this.BottomRight = BottomRight;
            getGameBoard();
        }
        public GameBoard(GameBoard copyBoard)
        {
            this.ID = copyBoard.ID;
            this.TopLeft = copyBoard.TopLeft;
            this.TopMiddle = copyBoard.TopMiddle;
            this.TopRight = copyBoard.TopRight;
            this.MiddleLeft = copyBoard.MiddleLeft;
            this.MiddleMiddle = copyBoard.MiddleMiddle;
            this.MiddleRight = copyBoard.MiddleRight;
            this.BottomLeft = copyBoard.BottomLeft;
            this.BottomMiddle = copyBoard.BottomMiddle;
            this.BottomRight = copyBoard.BottomRight;
            getGameBoard();
        }
        public void getGameBoard()
        {
            dBGameBoard[0] = TopLeft;
            dBGameBoard[1] = TopMiddle;
            dBGameBoard[2] = TopRight;
            dBGameBoard[3] = MiddleLeft;
            dBGameBoard[4] = MiddleMiddle;
            dBGameBoard[5] = MiddleRight;
            dBGameBoard[6] = BottomLeft;
            dBGameBoard[7] = BottomMiddle;
            dBGameBoard[8] = BottomRight;
        }
        public void setGameBoard()
        {
            TopLeft = dBGameBoard[0];
            TopMiddle = dBGameBoard[1];
            TopRight = dBGameBoard[2];
            MiddleLeft = dBGameBoard[3];
            MiddleMiddle = dBGameBoard[4];
            MiddleRight = dBGameBoard[5];
            BottomLeft = dBGameBoard[6];
            BottomMiddle = dBGameBoard[7];
            BottomRight = dBGameBoard[8];
        }

        //overwritting the equals method so i can pass a DB Object into it and get an accurate equals
        public override bool Equals(object obj)
        {
            getGameBoard();//just to ensure the array is correctly updated with the variables
            GameBoard passedObject = (GameBoard)obj;
            for(int i = 0; i < passedObject.dBGameBoard.Length; i++)
            {
                if ((!dBGameBoard[i].Equals("X") && !passedObject.dBGameBoard[i].Equals("X"))
                    || (!passedObject.dBGameBoard[i].Equals("O") && dBGameBoard[i].Equals("O"))) // could have made it .Equals("-") but i think its more robust and allows me to pass DB objects with numbers aswell
                {
                    passedObject.dBGameBoard[i] = "-"; //shouldn't matter but its here
                    dBGameBoard[i] = "-";              //if its a dash here, it will be a number in the DB so i have to change it
                }
            }
            //found this code here:https://stackoverflow.com/questions/6196526/how-to-find-out-whether-two-string-arrays-are-equal-to-other
            //was having issues with Equals and string arrays
            IStructuralEquatable equ = dBGameBoard;
            if (equ.Equals(passedObject.dBGameBoard, EqualityComparer<string>.Default)){//because where there were numbers there are dashes and this is easier then checking the variables
                getGameBoard();//reset the gameboard to its numerical origins for AI decision
                return true;
            }
            getGameBoard();//reset the gameboard to its numerical origins for AI decision
            return false;
        }
        //this will take the "-" and turn it into a number when adding a new gameboard to the database
        public void SendToDatabase()
        {
            getGameBoard();
            ID = 0; // i have to reset the ID so that the datbase will autoincrement it
            for (int i = 0; i < dBGameBoard.Length; i++)
            {
                if (dBGameBoard[i].Equals("-"))
                {
                    dBGameBoard[i] = "0";
                }
            }
            setGameBoard();
        }
        //this is used to make the gameboard visually pleasing to the gamer
        public void ResetGameBoard()
        {
            for (int i = 0; i < dBGameBoard.Length; i++)
            {
                if (!dBGameBoard[i].Equals("X") || !dBGameBoard[i].Equals("O") || !dBGameBoard[i].Equals("-"))
                {
                    dBGameBoard[i] = "-";
                }
            }
            setGameBoard();
        }
        //simply put this will find where the X's and O's are and make it so the AI will NOT choose these spots
        public void SetAIGameBoard()
        {
            for (int i = 0; i < dBGameBoard.Length; i++)
            {
                if (dBGameBoard[i].Equals("X") || dBGameBoard[i].Equals("O"))
                {
                    aiDecisionBoard[i] = -500;
                    continue;
                }
                aiDecisionBoard[i] = int.Parse(dBGameBoard[i]);
            }
        }

        public void UpdateAI(string position, int learningRate)
        {
                switch (position)
                {
                    case "TopLeft":
                        TopLeft = (int.Parse(TopLeft) + learningRate).ToString();
                        break;
                    case "TopMiddle":
                        TopMiddle = (int.Parse(TopMiddle) + learningRate).ToString();
                        break;
                    case "TopRight":
                        TopRight = (int.Parse(TopRight) + learningRate).ToString();
                        break;
                    case "MiddleLeft":
                        MiddleLeft = (int.Parse(MiddleLeft) + learningRate).ToString();
                        break;
                    case "MiddleMiddle":
                        MiddleMiddle = (int.Parse(MiddleMiddle) + learningRate).ToString();
                        break;
                    case "MiddleRight":
                       MiddleRight = (int.Parse(MiddleRight) + learningRate).ToString();
                       break;
                    case "BottomLeft":
                       BottomLeft = (int.Parse(BottomLeft) + learningRate).ToString();
                       break;
                    case "BottomMiddle":
                        BottomMiddle = (int.Parse(BottomMiddle) + learningRate).ToString();
                        break;
                    case "BottomRight":
                        BottomRight= (int.Parse(BottomRight) + learningRate).ToString();
                        break;
                    default:
                        break;
                }//end switch
        }


    }
}
