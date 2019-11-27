using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLC_WebApp.Models
{
    public class Turn
    {
        public int ID = 0;
        public string position;
        public Turn (int ID, string position)
        {
            this.ID = ID;
            this.position = position;
        }
    }
}
