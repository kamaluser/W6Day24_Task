using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6Day24_Task
{
    internal class ShapeManager
    {
        public Shape[] Shapes;

        public int GetCircleCount(Shape[] shapes)
        {
            int count = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    count++;
                }
            }
            return count;
        }

        public Shape[] GetCircles(Shape[] shapes)
        {
            Circle[] circles = new Circle[0];
            for (int i = 0;i < shapes.Length;i++)
            {
                if (shapes[i] is Circle)
                {
                    Array.Resize(ref circles, circles.Length + 1);
                    circles[circles.Length - 1] = (Circle)shapes[i];
                }
            }
            return circles;
        }
        public double GetTotalCircleAreas(Shape[] shapes)
        {
            double total = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    total += shapes[i].CalculateArea();
                }
            }
            return total;
        }

        public int GetSquareCount(Shape[] shapes)
        {
            int count = 0;
            Rectangle rectangle = new Rectangle();
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Rectangle)
                {
                    rectangle = (Rectangle)shapes[i];
                    if (rectangle.Width == rectangle.Height)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public Shape[] AddShape(Shape[] shapes, Shape shape)
        {
            int countCircle = 0;
            int countRectangle = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle) countCircle++;
                else
                {
                    countRectangle++;
                }
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shape is Rectangle && countRectangle < 10)
                {
                    Array.Resize(ref shapes, shapes.Length + 1);
                    shapes[shapes.Length - 1] = shape;
                }
                else if (shape is Circle && countCircle < 10)
                {
                    Array.Resize(ref shapes, shapes.Length + 1);
                    shapes[shapes.Length - 1] = shape;
                }
                else
                {
                    Console.WriteLine("Max Count Reached!");
                }

            }
            return shapes;
        }
    }
}
