﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Elements
    {

        public int x { get; set; }
        public int y { get; set; }
        public char icon { get; set; } = ' ';
        public int id { get; set; } = 0; /**id for type objet
                                            *    null = 0
                                            *    wall = 1
                                            *    **/

        public Elements(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Elements()
        {
        }


    }
}
