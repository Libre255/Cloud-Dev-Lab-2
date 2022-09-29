using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Dev_Lab_2_Class_Library
{
    public class Cuboid:Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get { return (2 * Length * Width) + (2 * Length * Height) + (2 * Height * Width); } }
        public override float Volumen { get { return Length * Width * Height; } }
        private string IsCube { get { return (Height == Width && Height == Length) ? "cube" : "cuboid"; } }
        private float Height;
        private float Width;
        private float Length;

        public Cuboid(Vector3 C, Vector3 size)
        {
            Center = C;
            Height = size.Y;
            Width = size.X;
            Length = size.Z;
        }
        public Cuboid(Vector3 C, float w)
        {
            Center = C;
            Height = w;
            Width = w;
            Length = w;
        }

        public override string ToString() => $"{IsCube} @({Center.Y}, {Center.X}, {Center.Z}): w = {Width}, h = {Height}, l = {Length}";
    }
}
