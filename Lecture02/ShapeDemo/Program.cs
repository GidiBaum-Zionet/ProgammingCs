using System;
using BaseLib;
using ShapeLib;

var rect = new Rectangle();

rect.Color = System.Drawing.Color.BlueViolet;

var v = new Vector2d(1, 2);

var v1 = 3 * v;

var v2 = new Vector2d("(1.2323, -5)");

Console.WriteLine(v2);

Console.ReadKey();