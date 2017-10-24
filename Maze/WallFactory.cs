using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    /********************************************
     * 
     * the wall has a 4 bit digit that indicate if they have connection with other wall
     * 
     * 1 yes
     * 0 no
     *
     *  top   botton  right  left
     *   0      0      0      0
     * 
     * 
     * *****************************************/
    static public class WallFactory
    {
        public static Wall createWall(bool top, bool botton, bool right, bool left, int x, int y)
        {

            int id = calculateID( top,  botton,  right,  left);

            return new Wall(id,choseIconWall(id),top,botton,right, left, x, y);
        }

        private static int calculateID(bool top, bool botton, bool right, bool left)
        {
            int id = 0;

            if (top) id = id + 1000;
            if (botton) id = id + 100;
            if (right) id = id + 10;
            if (left) id = id + 1;

            return id;
        }
        public static Wall createWall(int id, int x, int y)
        {
            bool top = false;
            bool botton = false;
            bool right = false;
            bool left = false;

            int a = 0, b = 0;

            a = id / 1000;
            b = id % 1000;
 
            if (a == 1) top = true;

            a = b / 100;
            b = b % 100;

            if (a == 1) botton = true;

            a = b / 10;
            b = b % 10;

            if (a == 1) right = true;
            if (b == 1) left = true;

            return new Wall(id, choseIconWall(id), top, botton, right, left,  x,  y);
        }

        public static void updateWalls (Wall walltop, Wall wallbotton, Wall wallright, Wall wallleft, Wall wallcenter)
        {
           

            if (walltop != null )
            {
                wallcenter.top = true;
                walltop.botton = true;
                recalculateWall(walltop);

            }

            if (wallbotton != null)
            {
                wallcenter.botton = true;
                wallbotton.top = true;
                recalculateWall(wallbotton);

            }

            if (wallright != null)
            {
                wallcenter.right = true;
                wallright.left = true;
                recalculateWall(wallright);

            }

            if (wallleft != null)
            {
                wallcenter.left = true;
                wallleft.right = true;
                recalculateWall(wallleft);

            }

            wallcenter.recalculateWallId();
            wallcenter.icon = choseIconWall(wallcenter.wallid);

            Draw.drawIcon(wallcenter.icon, wallcenter.x, wallcenter.y);


        }
        public static void recalculateWall(Wall wall)
        {
            int wallid = 0;

            if (wall.top) wallid = wallid + 1000;
            if (wall.botton) wallid = wallid + 100;
            if (wall.right) wallid = wallid + 10;
            if (wall.left) wallid = wallid + 1;

            wall.wallid = wallid;
            wall.icon = choseIconWall(wallid);

            Draw.drawIcon(wall.icon, wall.x, wall.y);
        }
        private static char choseIconWall (int id)
        {
            char icon= ' ';
            switch(id)
            {
                case (0011):
                case (0010):
                case (0001):
                    icon = '═';
                    break;
                case (1100):
                case (1000):
                case (0100):
                    icon = '║';
                    break;
                case (1010):
                    icon = '╚';
                    break;
                case (1001):
                    icon = '╝';
                    break;
                case (0110):
                    icon = '╔';
                    break;
                case (0101):
                    icon = '╗';
                    break;
                case (1101):
                    icon = '╣';
                    break;
                case (1110):
                    icon = '╠';
                    break;
                case (1011):
                    icon = '╩';
                    break;
                case (0111):
                    icon = '╦';
                    break;
                case (0000):
                case (1111):
                    icon = '╬';
                    break;
                default:
                    icon = '■';
                    break;
            }
            return icon;
        }
    }
}
