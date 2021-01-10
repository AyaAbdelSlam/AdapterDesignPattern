using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    public class RoundHole
    {
        public double Raduis { get; set; }

        public RoundHole(double raduis)
        {
            this.Raduis = raduis;
        }

        public bool Fits(IPeg roundPeg)
        {
            return this.Raduis >= roundPeg.GetRaduis();
        }
    }
}
