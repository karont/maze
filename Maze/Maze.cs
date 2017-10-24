using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Maze
{
    public class Maze
    {
        public  Elements[,] box { get; set; }

        public Elements[,] inibox { get; set; }

        public int ysize { get; set; }
        public int xsize { get; set; }


        public Maze(int x = 20, int y = 20)
        {
            this.xsize = x;
            this.ysize = y;
            

            box = new Elements[this.xsize,this.ysize ];
            buildMaze();
        }

        private void buildMaze()
        {

            for (int i = 0; i < xsize; i++)
            {
                for (int j = 0; j < ysize; j++)
                {

                    box[i, j] = new Elements(i,j);
                }

            }
            box[0, 0] = WallFactory.createWall(0110, 0 ,0);
            box[xsize - 1, 0] = WallFactory.createWall(0101 , xsize - 1, 0);
            box[0, ysize-1] = WallFactory.createWall(1010, 0, ysize - 1);
            box[ysize - 1, xsize - 1] = WallFactory.createWall(1001, ysize - 1, xsize - 1);

            for (int i = 1; i < ysize - 1; i++)
            {
                box[0, i] = WallFactory.createWall(1100, 0, i);
                box[xsize - 1, i] = WallFactory.createWall(1100, xsize - 1, i);
            }

            for (int i = 1; i < xsize - 1; i++)
            {
                box[i, 0] = WallFactory.createWall(0011,i, 0);
                box[i, ysize - 1] = WallFactory.createWall(0011, i, ysize - 1);
            }

        }

        public void drawMaze()
        {
            for (int i = 0; i < xsize; i++)
            {
                for (int j = 0; j < ysize; j++)
                {
                    Console.SetCursorPosition(i,j);
                    Console.Write(box[i,j].icon);
                }

            }
            Console.SetCursorPosition(1, 1);
        }

        public void drawElement(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(box[x, y].icon);
        }

        public void drawWall(int x, int y)
        {
            Wall top = null;
            Wall botton = null;
            Wall right = null;
            Wall left = null;
            Wall center = new Wall();


            if (y > 1)
                if (box[x, y--].id == 1) top = (Wall)box[x, y--];  //wall on top
            if (y < ysize--)
                if (box[x, y++].id == 1) botton = (Wall)box[x, y++];  //wall on botton
            if (x < xsize--)
                if (box[x++, y].id == 1) right = (Wall)box[x, y--];  //wall on right
            if (x > 1)
                if (box[x--, y].id == 1) left = (Wall)box[x, y--];  //wall on left

            WallFactory.updateWalls(top, botton, right, left, center);


        }
    }
}
