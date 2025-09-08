namespace DemoApp
{
    public interface INotificationService
    {
        void Notify(string message);
    }

    public class BankAccount
    {
        private readonly INotificationService _notification;
        public decimal Balance { get; private set; }

        public BankAccount(INotificationService notification)
        {
            _notification = notification;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            _notification.Notify($"Deposited {amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds!");

            Balance -= amount;
            _notification.Notify($"Withdrew {amount}");
        }
    }
}
