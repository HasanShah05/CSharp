using System;
using System.Collections.Generic;

namespace ShapePolymorphism
{
    public class Shape
    {
        public int x { get; init; }
        public int y { get; init; }
        public int height { get; init; }
        public int width { get; init; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing the base class tasks:");
            
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drwaing a circle");
            base.Draw();
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drwaing a Rectangle");
            base.Draw();
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drwaing a Triangle");
            base.Draw();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle(),
            };
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}