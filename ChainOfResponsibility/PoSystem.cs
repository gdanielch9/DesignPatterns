using System;

namespace ChainOfResponsibility
{
   public class PoSystem
   {
      protected PoApprover approvalChain;

      public PoSystem()
      {
         approvalChain = new Manager(new VicePresident(new Ceo(null)));
      }

      public void ProcessRequest(decimal price)
      {
         approvalChain.ProcessRequest(price);
      }
   }
}
