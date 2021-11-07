using System;
using ConsoleApp2;

Console.WriteLine("Object Oriented Programming");

int[] arr = new int[12];

var car01 = new Car();
car01.Color = "Red";
//car01.SetColor("Red");

var type = car01.GetType();
var str = car01.ToString();

var car02 = new Car
{
    Color = "Blue"
};
//car02.SetColor("Blue");

var premiumCar = new Car("0000-0000-9999");
premiumCar.Color = "Black";


car01.Drive();

//var v = new Vehicle(); // vehicle is abstract



Console.ReadKey();