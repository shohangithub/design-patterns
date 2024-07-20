namespace Strategy_Problem;

internal class PaymentGateway
{
    public void Payment(string PaymentMethod)
    {
        // --- BKASH, NAGAD, ROCKET  ---

        Console.WriteLine("proccessing...");

        if (PaymentMethod == "BKASH")
        {
            // implement algorithm or api proccess here
            Console.WriteLine("payment throw bkash.");
        }
        else if(PaymentMethod == "NAGAD")
        {
            // implement algorithm or api proccess here
            Console.WriteLine("payment throw nagad.");
        }
        else if (PaymentMethod == "ROCKET")
        {
            // implement algorithm or api proccess here
            Console.WriteLine("payment throw rocket.");
        }
    }
}
