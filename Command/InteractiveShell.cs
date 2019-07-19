using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   public class InteractiveShell
   {
      public void Run()
      {
         var mathlib = new MathLib();
         var calculator = new Calculator();

         AbstractOperation op = new Operation(mathlib, "+", 100);
         calculator.Invoke(op);
         Console.WriteLine(mathlib.Value);
         AbstractOperation op2 = new Operation(mathlib, "*", 5);
         calculator.Invoke(op2);
         Console.WriteLine(mathlib.Value);
         calculator.Undo();
         Console.WriteLine(mathlib.Value);

         Console.ReadKey();
      }
   }
}
