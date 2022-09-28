using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Cloud_Dev_Lab_2_Class_Library
{
    public class Rectangle: Shape2D
    {
        public override float Area { get { return Width * Height; } }
        public override Vector3 Center { get; }
        public override float Circumference { get { return 2 * (Width * Height); } }
        public bool IsSquare { get { return Width == Height ? true : false; } }
        private float Width;
        private float Height;

        public Rectangle(Vector2 C, Vector2 size)
        {
            Center = new Vector3(C, 0.0f);
            Height = size.Y;
            Width = size.X;
        }
        public Rectangle (Vector2 C, float w)
        {
            Center = new Vector3(C, 0.0f);
            Width = w;
            Height = w;
        }

        public override string ToString()
        {
            return $"{(IsSquare ? "square" : "rectangle")} @({Center.Y}, {Center.X}): w = {Width}, h = {Height}.";
        }
    }
}
