using static System.Console;
using Cloud_Dev_Lab_2_Class_Library;

namespace Cloud_Dev_Lab_2
{
    public class Program
    {
        static public void Main()
        {
            float TotalArea = 0;
            Shape[] ListOfShapes = ArrayOfShapes();
            foreach(Shape S in ListOfShapes)
            {
                WriteLine(S.ToString());
                TotalArea += S.Area;
            }
            WriteLine(" ");
            WriteLine($"Genomsnittliga area = {TotalArea/ListOfShapes.Length}");
        }
        static public Shape[] ArrayOfShapes()
        {
            List<Shape> SL = new();
            for(int i = 0; i < 21; i++)
            {
                SL.Add(Shape.GenerateShape());
            }
            return SL.ToArray();
        }
    }
}