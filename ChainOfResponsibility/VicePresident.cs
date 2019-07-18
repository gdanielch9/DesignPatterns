using System;

namespace ChainOfResponsibility
{
   public class VicePresident : PoApprover
   {
      public VicePresident(PoApprover successor)
      {
         _successor = successor;
      }

      public override void ProcessRequest(decimal price)
      {
         if (price <= 25000)
         {
            Console.WriteLine($"Transakcja na kwotę {price} zaakceptowana przez {this.GetType()}");
         }
         else if (_successor != null)
         {
            _successor.ProcessRequest(price);
         }
      }
   }
}
