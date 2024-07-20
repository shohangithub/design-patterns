using Stratrgy_Solution.Strategy;

namespace Stratrgy_Solution.Context;
internal class PaymentGateway
{
    public void Payment(IPaymentGateway paymentGateway)
    {
        paymentGateway.Payment();
    }
}