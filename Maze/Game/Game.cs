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

        int x = 1, y = 1; // Contains current cursor position.
        int lastx = 1, lasty = 1; // Contains last current cursor position.
        public Game ()
        {
            Console.SetWindowSize(Console.LargestWindowWidth-150,Console.LargestWindowHeight-20);
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
                        if (y <  maze.ysize - 2)
                        {
                            y++;
                            move(x, y);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 1)
                        {
                            y--;
                            move(x, y);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 1)
                        {
                            x--;
                            move(x, y);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < maze.xsize - 2)
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

            Draw.drawPosition(x, y);

        }
        private  void move( int x, int y)
        {
            try
            {
                if (x >= 0 && y >= 0) // 0-based
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
        private void drawElement()
        {

        }
    }
}
