using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            IShape shape1 = shapeFactory.getShape(ShapeType.Circle);
            shape1.Draw();

            //get an object of Rectangle and call its draw method.
            IShape shape2 = shapeFactory.getShape(ShapeType.Rectangle);
            shape2.Draw();

            //get an object of Square and call its draw method.
            IShape shape3 = shapeFactory.getShape(ShapeType.Square);
            shape3.Draw();

            Console.ReadKey();
        }
    }
}
