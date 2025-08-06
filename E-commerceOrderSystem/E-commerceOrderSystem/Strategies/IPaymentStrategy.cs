namespace Strategies
{
    public interface IPaymentStrategy
    {
        bool ProcessPayment(decimal amount);
    }
}
