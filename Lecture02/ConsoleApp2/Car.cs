using System;
using System.Drawing;

namespace ConsoleApp2
{

    // Basic Class Definition:

    // 0) Members (functions, fields, properties)
    // 1) Encapsulation (public/private)
    // 2) Polymorphism

    // 3) Inheritance (protected)
    
    // 4) Operator Overloading

    class Car : Vehicle
    {
        //string _Color;

        //---------------------------------
        // Setter/Getter

        //public void SetColor(string c)
        //{
        //    _Color = c;
        //}

        //public string GetColor()
        //{
        //    return _Color;
        //}

        // Properties:
        //---------------------------------

        string _Color;
        public string Color
        {
            set
            {
                _Color = value;
                Console.WriteLine($"Setting Color to {value}");
            }
            get
            {
                return _Color;
            }
        }

        public string Id { get; }

        private string FuelPumpId;


        // static fields / properties

        // static constructor

        static Car()
        {
            _Counter = 1;
        }

        public static string Manufacturer { get; }

        static int _Counter;

        public Car()
        {
            Id = $"{_Counter:D7}";
            _Counter++;

            Console.WriteLine("Car CTOR");

            FuelPumpId = "45645-B324234";
            NumberOfWheels = 4;
        }

        public Car(string id)
        {
            Id = id;

            Console.WriteLine("Car CTOR");

            FuelPumpId = "45645-B324234";
            NumberOfWheels = 4;
        }

        public override void Drive()
        {
            Console.WriteLine("Driving...");

            NumberOfWheels = 8;
            PrivateData = 10;

            RunMotor();
        }

        public void Drive(string area)
        {
            Console.WriteLine($"Driving in {area}...");

            RunMotor();
        }


        private void RunMotor()
        {

        }

        public override string ToString()
        {
            return $"Car Id={Id} color: {Color}";
        }
    }
}
