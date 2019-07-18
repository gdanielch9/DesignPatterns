
namespace ChainOfResponsibility
{
   public abstract class PoApprover
   {
      protected PoApprover _successor;

      public abstract void ProcessRequest(decimal price);
   }
}
