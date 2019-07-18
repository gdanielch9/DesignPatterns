using System;

namespace ChainOfResponsibility
{
   public class Manager : PoApprover
   {
      public Manager(PoApprover successor)
      {
         _successor = successor;
      }

      public override void ProcessRequest(decimal price)
      {
         if (price <= 10000)
         {
            Console.WriteLine($"Transakcja na kwotę {price} zaakceptowana przez {this.GetType()}");
         } else if (_successor != null)
         {
            _successor.ProcessRequest(price);
         }
      }
   }
}
