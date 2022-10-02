using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Dev_Lab_2_Class_Library
{
    public class Circle:Shape2D
    {
        public override float Area { get { return (float)Math.PI * (float)Math.Pow(Radius, 2); }  }
        public override Vector3 Center { get; }
        public override float Circumference { get { return 2 * (float)Math.PI * Radius; } }
        private float Radius;

        public Circle(Vector2 C, float R)
        {
            Center = new Vector3(C, 0.0f);
            Radius = R;
        }

        public override string ToString() => $"circle @({Center.Y} {Center.X}): r = {Radius}";
    }
}
