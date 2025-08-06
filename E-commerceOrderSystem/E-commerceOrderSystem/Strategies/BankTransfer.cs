using System;

namespace Strategies
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter routing number: ");
            string routing = Console.ReadLine();

            if (accountNumber.Length >= 8 && routing.Length == 9)
            {
                Console.WriteLine("Bank Transfer payment successful.");
                return true;
            }

            Console.WriteLine("Bank Transfer payment failed.");
            return false;
        }
    }
}
