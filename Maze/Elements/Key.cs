using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Key : Element
    {
        

        public int keyid { get; set; } // the key id

        public Key(int keyid, char icon,  int x, int y) : base(x,y)
        {
            this.keyid = keyid;
            this.id = 3;
            this.icon = icon;         
        }
    }
}
