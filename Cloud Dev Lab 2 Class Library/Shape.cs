using System.Numerics;

namespace Cloud_Dev_Lab_2_Class_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            int RandomShapeÍndexNr = new Random().Next(0, 6);
            int RandomY = new Random().Next(0, 50);
            int RandomX = new Random().Next(0, 50);
            int RandomZ = new Random().Next(0, 50);

            switch (RandomShapeÍndexNr)
            {
                case 0: return new Circle(new Vector2(RandomY, RandomX), new Random().Next(0, 40));
                case 1: return new Rectangle(new Vector2(RandomY, RandomX), new Vector2(RandomX, RandomY));
                case 2: return new Rectangle(new Vector2(RandomY, RandomX), new Random().Next(0, 40));
                case 3: return new Sphere(new Vector3(RandomY, RandomX, RandomZ), new Random().Next(0, 40));
                case 4: return new Cuboid(new Vector3(RandomY, RandomX, RandomZ), new Vector3(RandomZ, RandomX, RandomY));
                case 5: return new Cuboid(new Vector3(RandomY, RandomX, RandomZ), new Random().Next(0, 40));
                default: return new Circle(new Vector2(RandomY, RandomX), new Random().Next(0, 40));
            }
        }
    }
}