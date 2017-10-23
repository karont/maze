using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maze
{
    class Game
    {
        public Maze maze;
        const char toWrite = '*'; // Character to write on-screen.

        int x = 0, y = 0; // Contains current cursor position.
        int lastx = 0, lasty = 0; // Contains last current cursor position.
        public Game ()
        {
            Console.SetWindowSize(85, 85);
            Console.CursorVisible = true;

            maze = new Maze(50, 50);
            maze.drawMaze();
            run();
        }

        public void run()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey().Key;

                    switch (command)
                    {
                        case ConsoleKey.DownArrow:
                            if(y < maze.y-1)
                            {
                                y++;
                            }
                            
                            break;
                        case ConsoleKey.UpArrow:
                            if (y > 0)
                            {
                                y--;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (x > 0)
                            {
                                x--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if(x < maze.x-1)
                            {
                                x++;
                            }
                            
                            break;
                    }

                    Write(toWrite, x, y);
                }
            }
        }
        public  void Write(char toWrite, int x = 0, int y = 0)
        {
            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {

                    maze.drawElement(lastx, lasty);
                    Console.SetCursorPosition(x, y);
                    lastx = x;
                    lasty = y;
                    
                    //Console.Write(toWrite);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
