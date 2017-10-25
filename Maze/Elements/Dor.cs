using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Dor : Element
    {

        public bool open { get; set; } // true if its open

        public char orientation { get; set; } // h if its horizontal, v if its vertical

        public int dorid { get; set; } // the dor id

        public Dor(int dorid, char icon, bool open, char orientation, int x, int y) : base(x,y)
        {
            this.dorid = dorid;
            this.id = 2;
            this.icon = icon;
            this.open = open;
            this.orientation = orientation;
        }

    }
}
