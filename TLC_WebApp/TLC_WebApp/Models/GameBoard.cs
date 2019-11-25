using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            GameBoard passedObject = (GameBoard)obj;
            for(int i = 0; i < passedObject.dBGameBoard.Length; i++)
            {
                if (!passedObject.dBGameBoard[i].Equals("X") || !passedObject.dBGameBoard[i].Equals("O") || !passedObject.dBGameBoard[i].Equals("-"))
                {
                    passedObject.dBGameBoard[i] = "-";
                }
            }
            if (passedObject.dBGameBoard.Equals(dBGameBoard)){
                return true;
            }
            return false;
        }
        //this will take the "-" and turn it into a number when adding a new gameboard to the database
        public void SendToDatabase()
        {
            for (int i = 0; i < dBGameBoard.Length; i++)
            {
                if (dBGameBoard[i].Equals("-"))
                {
                    dBGameBoard[i] = "0";
                }
            }
            setGameBoard();
        }
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
    }
}
