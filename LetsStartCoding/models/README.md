# So what?
Here you have a basic class representing a point on a two dimensional space. It has two coordinates, *X* and *Y*. 
You also have a `Square` class, which defines an area between two points, and define a **method** to get it's area, like so:

```csharp
Point a = new Point();
a.X= 1;
a.Y = 1;

Point b = new Point();
b.X = 8;
b.Y = 16;

Square s = new Square();
s.StartingPOint = a;
s. EndingPoint = b;
```

The thing is, we don't care how the Square class calculates the area, we just encapsulate it's behaviour on that class, and hope for the best.
```csharp
s.StartingPoint = a;
s.EndingPoint = b;
Console.Out.WriteLineAsync("This is what I hope it's the square area: " + s.GetArea());
```