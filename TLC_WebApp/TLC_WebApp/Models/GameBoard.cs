using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLC_WebApp.Models
{
    public class GameBoard
    {
        public virtual int ID { get; set; }
        public virtual String[] DBGameBoard { get; set; } = new string[9];
    }
}
