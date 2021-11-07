using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Vehicle
    {
        public int NumberOfWheels { get; protected set; }
        protected int PrivateData { get; set; }

        public abstract void Drive();

        protected Vehicle()
        {
            PrivateData = 9;
        }
    }
}
