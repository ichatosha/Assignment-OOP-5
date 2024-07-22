using assignment_oop_5.project_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_5.project_1.Classes
{
    internal class Point3D : IPoint3D
    {
        public int X { get ; set ; }
        public int Y { get ; set ; }
        public int Z { get ; set ; }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public int CompareTo(Point3D? other)
        {
            if (X != other.X) return X.CompareTo(other.X);
            return Y.CompareTo(other.Y);
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Point3D p1 = (Point3D)obj;
            return (X == p1.X) && (Y == p1.Y) && (Z == p1.Z);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(X, Y, Z).GetHashCode();
        }

        public static bool operator == (Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, null)) return ReferenceEquals(p2, null);
            return p1.Equals(p2);
        }

        public static bool operator != (Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }
    }
}
