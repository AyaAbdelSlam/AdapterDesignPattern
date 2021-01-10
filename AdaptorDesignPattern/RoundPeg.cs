using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    public class RoundPeg:IPeg
    {
        private double _raduis;
        public RoundPeg(double raduis)
        {
            this._raduis = raduis;
        }
        public RoundPeg()
        {

        }

        public double GetRaduis()
        {
            return this._raduis;
        }
    }
}
