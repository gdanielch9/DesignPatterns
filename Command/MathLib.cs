using System;

namespace Command
{
   public class MathLib
   {
      protected int _value = 0;

      public int Value
      {
         get { return _value; }
      }

      public void Add(int argument)
      {
         _value += argument;
      }

      public void Substract(int argument)
      {
         _value -= argument;
      }

      public void Multiply(int argument)
      {
         _value *= argument;
      }

      public void Divide(int argument)
      {
         _value /= argument;
      }
   }
}
