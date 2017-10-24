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
    static class WallFactory
    {
        public static Wall createWall(bool top, bool botton, bool right, bool left, int x, int y)
        {

            int id=0;

            if (top) id = id + 1000;
            if (botton) id = id + 100;
            if (right) id = id + 10;
            if (left) id = id + 1;


            return new Wall(1,id,choseIconWall(id),top,botton,right, left, x, y);
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

            a = id / 100;
            b = id % 100;

            if (a == 1) botton = true;

            a = id / 10;
            b = id % 10;

            if (a == 1) right = true;
            if (b == 1) left = true;

            return new Wall(1,id, choseIconWall(id), top, botton, right, left,  x,  y);
        }

        public static void updateWalls (Wall top, Wall botton, Wall right, Wall left, Wall center)
        {

        }
        private static char choseIconWall (int id)
        {
            char icon= ' ';
            switch(id)
            {
                case (0011):
                    icon = '═';
                    break;
                case (1100):
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
                case (1111):
                    icon = '╬';
                    break;


            }
            return icon;
        }
    }
}
