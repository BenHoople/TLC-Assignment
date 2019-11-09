using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLC_WebApp.Models
{
    public class Game
    {
        private String[] gameBoard = new String[9];
        private String x = "X", o = "O", fill = "-";
        private byte choice;
        private String turn;
        //private Scanner scanner = new Scanner(System.in);
        private bool playable;

        public Game()
        {
            this.gameBoard = fillBoard();
            this.turn = x;
            this.playable = true;
        }
        public void move()
        {
            this.choice = takeInput();
            this.gameBoard[choice - 1] = this.turn;
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

            //return scanner.nextByte();
            return 10;
        }

        private String[] fillBoard()
        {
            int i = 0;
            for (int x = 0; x < this.gameBoard.Length; x++)
            {
                this.gameBoard[x] = this.fill;
                i++;
                if (i == 3)
                {
                    i = 0;
                }
            }
            return gameBoard;
        }

        public bool isPlayable()
        {
            return playable;
        }
    }
}
