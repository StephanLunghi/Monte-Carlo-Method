﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo_Method
{
    public struct coordinates
    {
        double x;
        double y;

        public coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public coordinates(Random random)
        {
            this.x = random.NextDouble();
            this.y = random.NextDouble();
        }
        public double Hypot()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }
}
}   

