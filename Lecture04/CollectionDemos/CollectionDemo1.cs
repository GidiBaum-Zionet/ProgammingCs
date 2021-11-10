using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CollectionDemos
{
    public class CollectionDemo1
    {
        public static void Run()
        {
            Console.WriteLine("CollectionDemo1");

            var numbers = new List<int>();

            for (var i = 0; i < 10; i++)
            {
                numbers.Add(i * 10);
            }

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var sum = numbers.Sum();
            var max = numbers.Max();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Max = {max}");
        }
    }
}
