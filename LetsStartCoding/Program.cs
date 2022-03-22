// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using TrackglobeCampus.OneOOne.Models;

Point origen = new Point();
origen.X =1;
origen.Y = 1;

Point fin = new Point();
fin.X = 5;
fin.Y = 5;

var square = new Square{
    StartingPoint = origen,
    EndingPoint = fin
};

Console.Out.WriteLineAsync("Esto es sólo el principio de lo que puede hacer un cuadrado de área  " + square.GetArea());