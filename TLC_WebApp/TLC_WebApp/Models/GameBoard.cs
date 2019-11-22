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
    }
}
