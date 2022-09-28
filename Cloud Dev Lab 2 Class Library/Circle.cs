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
        public override float Area { get; //formula  }
        public override Vector3 Center { get; }
        public override float Circumference { get { 
            return //formulan 
            } }
        private float R = 0;

        public Circle(Vector2 _Center, float Radius)
        {
            Center = new Vector3(_Center, 0.0f);
            R = Radius;
        }

        public override string ToString()
        {
            return $"Circle @{Center.X} {Center.Y}: r{R}";
        }
    }
}
