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
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }
    }
}
