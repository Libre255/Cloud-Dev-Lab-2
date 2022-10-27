using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Dev_Lab_2_Class_Library
{
    public class Sphere:Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get { return 4 * (float)Math.PI * (float)Math.Pow(Radius, 2); } }
        public override float Volumen { get { return (4 / 3) * (float)Math.PI * Radius * Radius * Radius; } }
        private float Radius;

        public Sphere(Vector3 C, float R)
        {
            Center = C;
            Radius = R;
        }
        public override string ToString() => $"sphere @({Center.Y}, {Center.X}, {Center.Z}): r = {Radius}";
    }
}
