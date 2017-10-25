using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Trap : Element
    {
        public int trapid { get; set; } // the key id

        public Trap(int trapid, char icon, int x, int y) : base(x,y)
        {
            this.trapid = trapid;
            this.id = 4;
            this.icon = icon;
        }
    }
}
