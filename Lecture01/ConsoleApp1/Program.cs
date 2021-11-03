
using System;
using ConsoleApp1;

//var x = 1.5;

//var y = 2;

//var z = x + y;

var text = "ABCDEFG";

Console.WriteLine(text);

var numChars = text.Length;

if (numChars > 5)
{
    Console.WriteLine("text has more then 5 chars");
}
else
{
    Console.WriteLine("text is short");

}

//int sum = 0;
//for (var i = 1; i <= 100; i++)
//{
//    sum += i;
//    Console.WriteLine(i);
//}

//Console.WriteLine($"The result is {sum}");

var arr = new int[12];

//for (var i = 0; i < 12; i++)
//{
//    arr[i] = 2 * i;
//}

//Console.WriteLine(arr[7]);

var q = MathFunctions.Add(10, 20);

Console.WriteLine(q);

var x = 25.0;
SqrtComputation.Tolerance = 0.0001;

try
{
    var sqrtX = SqrtComputation.CalculateSqrt(x);


    Console.WriteLine($"SQRT({x}) = {sqrtX}");
    Console.WriteLine($"s*s = {sqrtX * sqrtX}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}

Console.ReadKey();
Console.WriteLine("Press any key...");


