using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BaseLib;
using LinqDemo.Models;
using Newtonsoft.Json;
using static BaseLib.MathFunctions;

namespace CollectionDemos
{
    public class CollectionDemo3
    {
        public static void Run()
        {
            Console.WriteLine("CollectionDemo3");


            var exePath = Path.GetDirectoryName(
                typeof(CollectionDemo3).Assembly.Location);

            var filename = Path.Combine(exePath, "Data", "MOCK_DATA.json");

            var text = File.ReadAllText(filename);

            var people = JsonConvert.DeserializeObject<List<Person>>(text);


            var firstPeople = people.Skip(10).Take(10);

            foreach (var p in firstPeople)
            {
                Console.WriteLine(p);
            }

        }
    }
}
