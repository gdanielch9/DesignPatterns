using System;

namespace Factory
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Pozdrowienia z metody Draw() obiektu 'Rectangle'!");
        }
    }
}
