using System;
using System.Collections;


namespace Overriding
{

    internal abstract class Shape
    {
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public abstract void Draw();
        public void ShowPosition()
        {
            System.Console.WriteLine("Position {0}, {1}", PositionX, PositionY);
        }
    }


    internal class Circle: Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw circle at position {0}, {1}.", PositionX, PositionY);
        }
    }


    internal class Square: Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw square at position {0}, {1}", PositionX, PositionY);
        }
    }


    internal class Canvas
    {
        private readonly List<Shape> _shapes = new List<Shape>(); 

        public void AddFigure(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void DrawAll()
        {
            foreach (var shape in _shapes)
            {
                shape.Draw();
            }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.AddFigure(new Circle() { PositionX = 1.0, PositionY=3.0 });
            canvas.AddFigure(new Square() { PositionX = 3.0, PositionY=4.0 });
            canvas.AddFigure(new Circle() { PositionX = 5.0, PositionY=5.0 });

            canvas.DrawAll(); 
        }
    }
}