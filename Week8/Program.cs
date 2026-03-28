using Week8;

Point p1 = new Point{X = 1, Y = 2};
Point p2 = p1;

p2.X = 20; 
p1.Print();
p2.Print();

Console.WriteLine();
PointRef r1  = new PointRef{X = 1, Y = 2};
PointRef r2 = r1;
r2.X = 100;
r1.Print();
r2.Print();
Console.WriteLine();

BoxingTester.Test();
Console.WriteLine();
