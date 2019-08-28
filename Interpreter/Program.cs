using System;

namespace Interpreter
{
   class Program
   {
      static void Main(string[] args)
      {
         Context context = new Context();

         // build a simple expression tree (usually a parser does this)
         // this expression tree represents the expression: '4+3'
         AbstractExpression tree =
            new NonterminalExpression(
               new TerminalExpression(4),
               new TerminalExpression(3));

         // interpret the expression
         Console.WriteLine("Result: {0}", tree.Interpret(context));
      }
   }
}
