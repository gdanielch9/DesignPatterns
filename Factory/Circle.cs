using System;

namespace Factory
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Pozdrowienia z metody Draw() obiektu 'Circle'!");
        }
    }
}
