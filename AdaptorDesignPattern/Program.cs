using System;

namespace AdaptorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somewhere in client code.
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            Console.WriteLine(hole.Fits(rpeg)); // true

            var small_sqpeg = new SquarePeg(5);
            var large_sqpeg = new SquarePeg(10);
            //Console.WriteLine(hole.Fits(small_sqpeg)); // this won't compile (incompatible types)

            var small_sqpeg_adapter = new SquarePegAdapter(small_sqpeg);
            var large_sqpeg_adapter = new SquarePegAdapter(large_sqpeg);
            Console.WriteLine(hole.Fits(small_sqpeg_adapter)); // true
            Console.WriteLine(hole.Fits(large_sqpeg_adapter)); // false
            Console.ReadLine();
            
        }
    }
}
