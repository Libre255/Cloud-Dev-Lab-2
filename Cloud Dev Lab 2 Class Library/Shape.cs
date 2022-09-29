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


            List<Shape> ListOfShapes = new() { new Circle(new Vector2(RandomY, RandomX), new Random().Next(0, 40) ), 
                                               new Rectangle(new Vector2(RandomY, RandomX), new Vector2(RandomX, RandomY)),
                                               new Rectangle(new Vector2(RandomY, RandomX), new Random().Next(0, 40)),
                                               new Sphere(new Vector3(RandomY, RandomX, RandomZ), new Random().Next(0, 40)),
                                               new Cuboid(new Vector3(RandomY, RandomX, RandomZ), new Vector3(RandomZ, RandomX, RandomY)),
                                               new Cuboid(new Vector3(RandomY, RandomX, RandomZ), new Random().Next(0, 40))  };
            
            return ListOfShapes[RandomShapeÍndexNr];
        }
    }
}