using System;

// Abstraction
public interface INotification
{
    void Send(string message);
}

// Concrete classes
public class EmailNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"Email sent: {message}");
}

public class SmsNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"SMS sent: {message}");
}

// Factory
public class NotificationFactory
{
    public static INotification Create(string type)
    {
        return type.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms"   => new SmsNotification(),
            _       => throw new Exception("Unknown notification type")
        };
    }
}

class Program
{
    static void Main()
    {
        var email = NotificationFactory.Create("email");
        email.Send("Hello via Email!");

        var sms = NotificationFactory.Create("sms");
        sms.Send("Hello via SMS!");
    }
}
