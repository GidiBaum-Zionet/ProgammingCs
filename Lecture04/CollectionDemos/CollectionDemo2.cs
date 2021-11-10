using System;
using System.Collections.Generic;
using BaseLib;
using static BaseLib.MathFunctions;

namespace CollectionDemos
{
    public class CollectionDemo2
    {
        public static void Run()
        {
            Console.WriteLine("CollectionDemo2");

            var vectors = new List<Vector2d>();

            for (var i = 0; i < 10; i++)
            {
                vectors.Add(vec2(i, -i));
            }

            foreach (var n in vectors)
            {
                Console.WriteLine(n);
            }
        }
    }
}
