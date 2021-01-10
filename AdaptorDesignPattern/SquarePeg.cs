using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    public class SquarePeg 
    {
        private double _width;

        public SquarePeg(double width)
        {
            this._width = width;
        }

        public double GetWidth()
        {
            return this._width;
        }
    }
}
