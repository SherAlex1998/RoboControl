using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    struct Vector2d
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Vector2d(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public Vector2d Normalize()
        {
            return new Vector2d(x / this.Magnitude(), y / this.Magnitude());
        }

        public bool IsNull()
        {
            if (x == 0 && y == 0) return true; else return false;
        }

        public static Vector2d operator + (Vector2d rightValue, Vector2d leftValue)
        {
            return new Vector2d(rightValue.X + leftValue.X, rightValue.Y + leftValue.Y);
        }

        public static Vector2d operator - (Vector2d rightValue, Vector2d leftValue)
        {
            return new Vector2d(rightValue.X - leftValue.X, rightValue.Y - leftValue.Y);
        }

        public static Vector2d operator *(Vector2d rightValue, double arg)
        {
            return new Vector2d(rightValue.X * arg, rightValue.Y * arg);
        }

        public static Vector2d operator /(Vector2d rightValue, double arg)
        {
            return new Vector2d(rightValue.X / arg, rightValue.Y / arg);
        }

        public static bool operator >(Vector2d rightValue, Vector2d leftValue)
        {
            return leftValue.Magnitude() > rightValue.Magnitude(); 
        }

        public static bool operator <(Vector2d rightValue, Vector2d leftValue)
        {
            return leftValue.Magnitude() < rightValue.Magnitude();
        }

        override public string ToString()
        {
            return "x: " + x.ToString() + " y: " + y.ToString();
        }

        public Point ToPoint()
        {
            return new Point((int)x, (int)y);
        }
    }
}
