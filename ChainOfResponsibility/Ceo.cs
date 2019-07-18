using System;

namespace ChainOfResponsibility
{
   public class Ceo : PoApprover
   {
      public Ceo(PoApprover successor)
      {
         _successor = successor;
      }

      public override void ProcessRequest(decimal price)
      {
         if (price <= 100000)
         {
            Console.WriteLine($"Transakcja na kwotę {price} zaakceptowana przez {this.GetType()}");
         }
         else
         {
            Console.WriteLine($"Należy zaplanować spotkanie, by zaakceptować kwotę {price}");
         }
      }
   }
}
