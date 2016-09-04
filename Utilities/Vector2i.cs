using UnityEngine;

namespace Utilities
{
    public class Vector2i
    {
        public int x;
        public int y;

        public int sqrMagnitude {
            get { return x * x + y * y; }
        }

        public float magnitude
        {
            get { return Mathf.Sqrt(sqrMagnitude); }
        }

        public Vector2 normalized
        {
            get { return new Vector2(x, y).normalized; }
        }

        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2i(Vector2 a)
        {
            this.x = (int) a.x;
            this.y = (int) a.y;
        }

        public static int Dot(Vector2i a, Vector2i b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static float Dot(Vector2i a, Vector2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static float Dot(Vector2 a, Vector2i b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static Vector2i operator +(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator +(Vector2i a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator +(Vector2 a, Vector2i b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2i operator -(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator -(Vector2i a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator -(Vector2 a, Vector2i b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static Vector2i operator *(Vector2i a, int s)
        {
            return new Vector2i(a.x * s, a.y * s);
        }

        public static Vector2 operator *(Vector2i a, float s)
        {
            return new Vector2(a.x * s, a.y * s);
        }

        public static Vector2i operator *(int s, Vector2i a)
        {
            return new Vector2i(a.x * s, a.y * s);
        }

        public static Vector2 operator *(float s, Vector2i a)
        {
            return new Vector2(a.x * s, a.y * s);
        }

        public static Vector2i operator /(Vector2i a, int s)
        {
            return new Vector2i(a.x / s, a.y / s);
        }

        public static Vector2 operator /(Vector2i a, float s)
        {
            return new Vector2(a.x / s, a.y / s);
        }

        public static bool operator ==(Vector2i a, Vector2i b)
        {
            return (a.x == b.x && a.y == b.y);
        }

        public static bool operator !=(Vector2i a, Vector2i b)
        {
            return (a.x != b.x || a.y != b.y);
        }

        public override bool Equals(object obj) 
        {
            Vector2i v = obj as Vector2i;
            if (v != null)
            {
                return (x == v.x && y == v.y);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}
