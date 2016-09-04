using UnityEngine;

namespace Utilities
{
    public struct Vector2i
    {
        public int x;
        public int y;

        public int sqrMagnitude
        {
            get
            {
                return x * x + y * y;
            }
        }

        public float magnitude
        {
            get
            {
                return Mathf.Sqrt(sqrMagnitude);
            }
        }

        public Vector2 normalized
        {
            get
            {
                return ((Vector2) this).normalized;
            }
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

        public static Vector2 operator /(Vector2i a, float s)
        {
            return new Vector2(a.x / s, a.y / s);
        }

        public static bool operator ==(Vector2i a, Vector2i b)
        {
            return a.Equals(b);
        }

        public static bool operator ==(Vector2i a, Vector2 b)
        {
            return a.Equals(b);
        }

        public static bool operator ==(Vector2 a, Vector2i b)
        {
            return b.Equals(a);
        }

        public static bool operator !=(Vector2i a, Vector2i b)
        {
            return !a.Equals(b);
        }

        public static bool operator !=(Vector2i a, Vector2 b)
        {
            return !a.Equals(b);
        }

        public static bool operator !=(Vector2 a, Vector2i b)
        {
            return !b.Equals(a);
        }

        public static explicit operator Vector2i(Vector2 a)
        {
            return new Vector2i((int) a.x, (int) a.y);
        }

        public static implicit operator Vector2(Vector2i a)
        {
            return new Vector2(a.x, a.y);
        }

        public override bool Equals(object other)
        {
            if (other is Vector2i)
            {
                Vector2i v = (Vector2i) other;
                return (x == v.x && y == v.y);
            }
            if (other is Vector2)
            {
                Vector2 v = (Vector2) other;
                return v.Equals((Vector2) this);
            }

            return false;
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
