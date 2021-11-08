using System;
using BaseLib;
using ShapeLib;
using static BaseLib.MathFunctions;

var rect = new Rectangle();

rect.Color = System.Drawing.Color.BlueViolet;

var v = new Vector2d(1, 2);

var v1 = 3 * v;

var v2 = vec2("(1.2323, -5)");

var v3 = vec2(2,3);

//-------------------------------------

var s = sqrt(10);


Console.WriteLine(v2);

Console.ReadKey();