namespace Factory
{
    public class ShapeFactory
    {
        //use getShape method to get object of type shape 
        public IShape getShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Square:
                    return new Square();
            }

            return null;
        }
    }

    public enum ShapeType
    {
        Circle,
        Rectangle,
        Square
    }
}
