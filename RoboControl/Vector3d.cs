using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    struct Vector3d
    {
        private double x;
        private double y;
        private double z;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public Vector3d(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public Vector3d Normalize()
        {
            return new Vector3d(x / this.Magnitude(), y / this.Magnitude(), z / this.Magnitude());
        }

        public bool IsNull()
        {
            if (x == 0 && y == 0 && z == 0) return true; else return false;
        }

        public static Vector3d operator +(Vector3d rightValue, Vector3d leftValue)
        {
            return new Vector3d(rightValue.X + leftValue.X, rightValue.Y + leftValue.Y, rightValue.Z + leftValue.Z);
        }

        public static Vector3d operator -(Vector3d rightValue, Vector3d leftValue)
        {
            return new Vector3d(rightValue.X - leftValue.X, rightValue.Y - leftValue.Y, rightValue.Z - leftValue.Z);
        }

        public static Vector3d operator *(Vector3d rightValue, double arg)
        {
            return new Vector3d(rightValue.X * arg, rightValue.Y * arg, rightValue.Z * arg);
        }

        public static Vector3d operator /(Vector3d rightValue, double arg)
        {
            return new Vector3d(rightValue.X / arg, rightValue.Y / arg, rightValue.Z / arg);
        }

        public static bool operator >(Vector3d rightValue, Vector3d leftValue)
        {
            return leftValue.Magnitude() > rightValue.Magnitude();
        }

        public static bool operator <(Vector3d rightValue, Vector3d leftValue)
        {
            return leftValue.Magnitude() < rightValue.Magnitude();
        }

        public static double Angle(Vector3d a, Vector3d b)
        {
            return Math.Acos((a.x * b.x + a.y * b.y + a.z * b.z) / (a.Magnitude() * b.Magnitude()));
        }

        override public string ToString()
        {
            return "x: " + x.ToString() + " y: " + y.ToString();
        }
    }
}
