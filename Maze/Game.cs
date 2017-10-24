using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maze
{
    public class Game
    {
        public Maze maze; // Contains the maze

        int x = Constants.xstart+1, y = Constants.ystart+1; // Contains current cursor position.
        int lastx = Constants.xstart, lasty = Constants.ystart; // Contains last current cursor position.
        public Game ()
        {
            Console.SetWindowSize(Constants.height, Constants.width);
            Console.CursorVisible = true;

            maze = new Maze(30, 30);
            maze.drawMaze();
            run();
        }

        public void run()
        {
            while (true)
            {
                action();
            }
        }

        private void action()
        {

            if (Console.KeyAvailable)
            {
                var command = Console.ReadKey().Key;

                switch (command)
                {
                    case ConsoleKey.DownArrow:
                        if (y < Constants.ystart + maze.ysize - 2)
                        {
                            y++;
                            move(x, y);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > Constants.ystart + 1)
                        {
                            y--;
                            move(x, y);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > Constants.xstart + 1)
                        {
                            x--;
                            move(x, y);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Constants.xstart +  maze.xsize - 2)
                        {
                            x++;
                            move(x, y);
                        }
                        
                        break;
                    case ConsoleKey.Q:

                        drawWall(x, y);
                        break;
                    case ConsoleKey.W:
                        deleteElement(x, y);
                        break;
                }

                drawPosition();
            }
        }

        private void drawPosition()
        {
            Console.SetCursorPosition(0, 60);
            Console.Write("x = {0}  y = {1}", x,y);
            Draw.setCursorPosition(x, y);



        }
        private  void move( int x, int y)
        {
            try
            {
                if (x >= Constants.xstart && y >= Constants.xstart) // 0-based
                {

                    maze.drawElement(lastx, lasty);
                    lastx = x;
                    lasty = y;
                    
                }
            }
            catch (Exception)
            {
            }
        }

        private void drawWall(int x, int y)
        {
            maze.drawWall(x, y);
        }
        
        private void deleteElement(int x, int y)
        {
            maze.deleteElement(x, y);
        }
    }
}
