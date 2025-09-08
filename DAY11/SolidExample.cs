using System;

// Abstraction (DIP)
public interface IPayment
{
    void Pay(decimal amount);
}

// Different payment methods (OCP)
public class CreditCard : IPayment
{
    public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} by Credit Card.");
}

public class PayPal : IPayment
{
    public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} by PayPal.");
}

// Order Service (SRP + DIP)
public class OrderService
{
    private readonly IPayment _payment;

    public OrderService(IPayment payment)
    {
        _payment = payment;
    }

    public void Checkout(decimal amount)
    {
        _payment.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        OrderService order1 = new OrderService(new CreditCard());
        order1.Checkout(200);

        OrderService order2 = new OrderService(new PayPal());
        order2.Checkout(500);
    }
}
