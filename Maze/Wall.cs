using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Wall : Elements
    {
        // id = 1
        public bool top { get; set; }    /**Conection with the other wall**/
        public bool botton { get; set; } /**Conection with the other wall**/
        public bool left { get; set; }  /**Conection with the other wall**/
        public bool right { get; set; }  /**Conection with the other wall**/
        public int wallid { get; set; }  // id for the wall type


        public Wall ( int wallid, char icon, bool top, bool botton, bool right, bool left, int x, int y) : base(x, y)
        {
            this.id = 1;
            this.wallid = wallid;
            this.icon = icon;
            this.top = top;
            this.botton = botton;
            this.left = left;
            this.right = right;
            

        }
        public Wall(int x, int y) : base(x, y)
        {
            this.id = 1;
            this.wallid = 0;
            this.icon = '□';
            this.top = false;
            this.botton = false;
            this.left = false;
            this.right = false;
        }

        public void changeWall(int wallid, char icon, bool top, bool botton, bool right, bool left)
        {
            this.wallid = wallid;
            this.icon = icon;
            this.top = top;
            this.botton = botton;
            this.left = left;
            this.right = right;

        }

        public void recalculateWallId()
        {
            int wallid = 0;

            if (top) wallid = wallid + 1000;
            if (botton) wallid = wallid + 100;
            if (right) wallid = wallid + 10;
            if (left) wallid = wallid + 1;

            this.wallid =  wallid;
        }
    
    }
}
