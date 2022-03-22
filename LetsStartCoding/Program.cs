// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using TrackglobeCampus.OneOOne.Models;

Point a = new Point();
a.X= 1;
a.Y = 1;

Point b = new Point();
b.X = 8;
b.Y = 16;

Square s = new Square();
s.StartingPoint = a;
s.EndingPoint = b;
Console.Out.WriteLineAsync("This is what I hope it's the square area: " + s.GetArea());