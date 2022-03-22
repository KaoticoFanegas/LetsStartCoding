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

Console.Out.WriteLineAsync("el area es  " + square.GetArea());