using System;

namespace Command
{
   public class Operation : AbstractOperation
   {
      protected MathLib _mathLib;
      protected string _operation;
      protected int _argument = 0;

      public Operation(MathLib mathlib, string operation, int argument)
      {
         _mathLib = mathlib;
         _operation = operation;
         _argument = argument;
      }

      public override void Execute()
      {
         switch (_operation)
         {
            case "+":
               _mathLib.Add(_argument);
               break;
            case "-":
               _mathLib.Substract(_argument);
               break;
            case "*":
               _mathLib.Multiply(_argument);
               break;
            case "/":
               _mathLib.Divide(_argument);
               break;
            default:
               throw  new InvalidOperationException();
         }
      }

      public override AbstractOperation Inverse
      {
         get
         {
            switch (_operation)
            {
               case "+":
                  return new Operation(_mathLib, "-", _argument);
               case "-":
                  return new Operation(_mathLib, "+", _argument);
               case "*":
                  return new Operation(_mathLib, "/", _argument);
               case "/":
                  return new Operation(_mathLib, "*", _argument);
               default:
                  throw new InvalidOperationException();
            }
         }
      }
   }
}
