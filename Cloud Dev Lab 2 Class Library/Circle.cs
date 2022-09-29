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
        public override float Area { get { return 3.14f * (Radius * Radius); }  }
        public override Vector3 Center { get; }
        public override float Circumference { get { return 2 * 3.14f * Radius; } }
        private float Radius;

        public Circle(Vector2 C, float R)
        {
            Center = new Vector3(C, 0.0f);
            Radius = R;
        }

        public override string ToString() => $"circle @({Center.Y} {Center.X}): r = {Radius}";
    }
}
