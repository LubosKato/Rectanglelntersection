using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using RectangleIntersection.Extensions;

[assembly: InternalsVisibleTo("RectangleIntersectionTest")]
namespace RectangleIntersection
{
    public class Vector2
    {
        public float X;
        public float Y;
        public static Vector2 Zero;

        public Vector2(float unitX, float unitY)
        {
            X = unitX;
            Y = unitY;
        }
    }

    internal class RectangleIntersect
    {
        public static int Solution(int blx1, int bly1, int trx1, int try1, int blx2, int bly2, int trx2, int try2)
        {
            var rectangle1 = new Rectangle(blx1, bly1, trx1 - blx1, try1 - bly1);
            var rectangle2 = new Rectangle(blx2, bly2, trx2 - blx2, try2 - bly2);
            //TOIMPLEMENT: add positioning logic for both rectangles !!!
            Vector2 vector = rectangle1.GetIntersectionDepth(rectangle2);
            float area = CalculateArea(vector);
            return (int)area;
        }

        private static float CalculateArea(Vector2 vector)
        {
            if (vector != null)
            {
                return vector.X * vector.Y;
            }
            return 0;
        }

        private static void Main()
        {
            int area = Solution(0, 2, 5, 10, 3, 1, 20, 15);
            if (area == 0)
                Console.WriteLine("There is no intersection");
            Console.WriteLine("Intersection area is " + area);
            Console.ReadLine();
        }
    }
}