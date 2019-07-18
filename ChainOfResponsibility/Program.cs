using System;

namespace ChainOfResponsibility
{
   class Program
   {
      static void Main(string[] args)
      {
         var poSystem = new PoSystem();

         poSystem.ProcessRequest(1000);
         poSystem.ProcessRequest(20000);
         poSystem.ProcessRequest(300000);

         Console.ReadKey();
      }
   }
}
