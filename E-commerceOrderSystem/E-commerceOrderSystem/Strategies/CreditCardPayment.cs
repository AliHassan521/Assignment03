using System;

namespace Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.Write("Enter card number: ");
            string cardNumber = Console.ReadLine();

            Console.Write("Enter expiry date (MM/YY): ");
            string expiry = Console.ReadLine();

            Console.Write("Enter CVV: ");
            string cvv = Console.ReadLine();

            if (cardNumber.Length == 16 && cvv.Length == 3)
            {
                Console.WriteLine("Credit Card payment successful.");
                return true;
            }

            Console.WriteLine("Credit Card payment failed.");
            return false;
        }
    }
}
