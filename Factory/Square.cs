using System;

namespace Factory
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Pozdrowienia z metody Draw() obiektu 'Square'!");
        }
    }
}
