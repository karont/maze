using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Maze
    {
        public Elements[,] box { get; set; }
        public int y { get; set; }
        public int x { get; set; }


        public Maze(int x = 20, int y = 20)
        {
            this.x = x;
            this.y = y;
            

            box = new Elements[this.x,this.y ];
            buildMaze();
        }

        private void buildMaze()
        {

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    box[i, j] = new Elements();
                }

            }
            box[0, 0] = new Wall('╔');
            box[x-1, 0] = new Wall('╗');
            box[0, y-1] = new Wall('╚');
            box[y - 1, x - 1] = new Wall('╝');

            for (int i = 1; i < y - 1; i++)
            {
                box[0, i] = new Wall('║');
                box[x - 1, i] = new Wall('║');
            }

            for (int i = 1; i < x - 1; i++)
            {
                box[i, 0] = new Wall('═');
                box[i, y - 1] = new Wall('═');
            }

        }

        public void drawMaze()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.SetCursorPosition(i,j);
                    Console.Write(box[i,j].icon);
                }

            }
            Console.SetCursorPosition(0, 0);
        }

        public void drawElement(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(box[x, y].icon);
        }
    }
}
