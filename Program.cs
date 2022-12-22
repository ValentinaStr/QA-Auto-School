// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;
using System.Drawing;
using System.Formats.Asn1;
using System.Numerics;

Point A = new Point();
A.Name = 'A';
A.x = 3;
A.y = 5;

Point B = new Point();
B.Name = 'B';
B.x = 4;
B.y = 6;

Point C = new Point();
C.Name = 'C';
C.x = 5;
C.y = 7;

Point D = new Point();
D.Name = 'D';
D.x = 4;
D.y = 5;

Point E = new Point();
E.Name = 'C';
E.x = 5;
E.y = 8;

Point F = new Point();
F.Name = 'F';
F.x = 9;
F.y = 1;

Point H = new Point();
H.Name = 'H';
H.x = 5;
H.y = 6;

Point J = new Point();
J.Name = 'J';
J.x = 5;
J.y = 3;

Point I = new Point();
I.Name = 'I';
I.x = 4;
I.y = 5;

Point K = new Point();
K.Name = 'K';
K.x = 4;
K.y = 5;

Point[] Points = { A, B, C, D, E, F, H, J, I, K };

foreach (Point point in Points)
{
    Console.WriteLine(point.GetInfo());
}

Console.WriteLine(Points[1].GetDistanse(C));

internal class Point
{
    public char Name;
    public int x;
    public int y;

    public string GetInfo()
    {
        return Name + " (" + x + ";" + y + ")";
    }

    public double GetDistanse(Point Second)
    {
        double distance = Math.Cbrt(Math.Pow((Second.x - x), 2) + Math.Pow((Second.y - y), 2));
        return distance;
    }

}

