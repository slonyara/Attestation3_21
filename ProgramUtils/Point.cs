﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramUtils
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static explicit operator Point(int v)
        {
            throw new NotImplementedException();
        }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
