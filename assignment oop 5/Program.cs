using assignment_oop_5.project_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region project 1
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());

            // Task 3
            Console.WriteLine("Enter coordinates for P1 (X, Y, Z):");
            int x1, y1, z1;
            int.TryParse(Console.ReadLine(), out x1);
            int.TryParse(Console.ReadLine(), out y1);
            int.TryParse(Console.ReadLine(), out z1);
            Point3D P1 = new Point3D(x1, y1, z1);

            Console.WriteLine("Enter coordinates for P2 (X, Y, Z):");
            int x2, y2, z2;
            int.TryParse(Console.ReadLine(), out x2);
            int.TryParse(Console.ReadLine(), out y2);
            int.TryParse(Console.ReadLine(), out z2);
            Point3D P2 = new Point3D(x2, y2, z2);

            // Task 4
            Console.WriteLine(P1 == P2);

            // Task 5
            List<Point3D> points = new List<Point3D> {
            new Point3D(3, 2, 1),
            new Point3D(1, 3, 2),
            new Point3D(2, 1, 3)
        };
            points.Sort();
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }

            // Task 6
            Point3D P3 = (Point3D)P1.Clone();
            Console.WriteLine($"Cloned Point: {P3}");

            #endregion


            #region Project 2

            int a = 10, b = 5;
            Maths maths = new Maths();
            Console.WriteLine($"Add: {maths.Add(a, b)}");
            Console.WriteLine($"Subtract: {maths.Subtract(a, b)}");
            Console.WriteLine($"Multiply: {maths.Multiply(a, b)}");
            Console.WriteLine($"Divide: {maths.Divide(a, b)}");
            #endregion


            #region Project 3

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            Console.WriteLine(D1 > D2);
            Console.WriteLine(D1 <= D2);

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt);

            #endregion
        }

    }
}