using System.Numerics;

namespace Cloud_Dev_Lab_2_Class_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }
}