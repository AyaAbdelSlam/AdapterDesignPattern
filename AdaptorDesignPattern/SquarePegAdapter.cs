using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    public class SquarePegAdapter:IPeg
    {
        private readonly SquarePeg _squarePeg;
        public SquarePegAdapter(SquarePeg squarePeg)
        {
            this._squarePeg = squarePeg;
        }

        public double GetRaduis()
        {
            return this._squarePeg.GetWidth() * Math.Sqrt(2) / 2;
        }
    }
}
