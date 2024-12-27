using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First_Program
{
    public class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y) : this(x, y, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public int CompareTo(object obj)
        {
            if (obj is Point3D other)
            {
                if (X != other.X)
                    return X.CompareTo(other.X);
                if (Y != other.Y)
                    return Y.CompareTo(other.Y);
                return Z.CompareTo(other.Z);
            }
            throw new ArgumentException("Object is not a Point3D");
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (p1 is null && p2 is null) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }
    }
}