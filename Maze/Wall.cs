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
        private bool top;    /**Conection with the other wall**/
        private bool botton; /**Conection with the other wall**/
        private bool left;   /**Conection with the other wall**/
        private bool right;  /**Conection with the other wall**/
        private int wallid;  // id for the wall type
        public Wall (int id, int wallid, char icon, bool top, bool botton, bool right, bool left, int x, int y) : base(x, y)
        {
            this.id = id;
            this.wallid = wallid;
            this.icon = icon;
            this.top = top;
            this.botton = botton;
            this.left = left;
            this.right = right;
            

        }
        public Wall() : base(){ }

        public void changeWall(int id,int wallid, , char icon, bool top, bool botton, bool right, bool left)
        {
            this.id = id;
            this.icon = icon;
            this.top = top;
            this.botton = botton;
            this.left = left;
            this.right = right;

        }
    }
}
