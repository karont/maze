using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public static class Draw
    {
        public static void drawIcon(char icon, int x, int y)
        {
            Console.SetCursorPosition(Constants.xstart + x, Constants.ystart + y);
            Console.Write(icon);
        }

        public static void setCursorInitialPosition ()
        {
            Console.SetCursorPosition(Constants.xstart+1, Constants.ystart+1);
        }

        public static void setCursorPosition(int x, int y)
        {
            Console.SetCursorPosition(Constants.xstart+x, Constants.ystart+y);
        }
    }
}
