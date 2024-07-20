using Stratrgy_Solution.Strategy;

namespace Stratrgy_Solution.Concrete_Strategy;

internal class NagadPaymentGateway : IPaymentGateway
{
    public void Payment()
    {
        Console.WriteLine("proccessing...");

        // implement algorithm or api proccess here
        Console.WriteLine("payment throw nagad.");

    }
}