public interface INotifier{
    void SendMessage(string message);
}

public class NotifierDecorator : INotifier{
    public INotifier _notifier;

    public NotifierDecorator(INotifier notifier){
        _notifier = notifier;
    }

    public virtual void SendMessage(string message){
        Console.WriteLine(message);
    }
}

public class EmailNotifier : INotifier
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"[Email] {message}");
    }
}

public class SMSNotifier: NotifierDecorator
{
    public SMSNotifier(INotifier notifier) : base(notifier)
    {
    }

    public override void SendMessage(string message){
        Console.WriteLine($"[SMS] {message}");
        _notifier.SendMessage(message);
    }
}

public static class Program{
    public static void Main(string[] arg){
        INotifier notifier = new SMSNotifier(new EmailNotifier());
        notifier.SendMessage("Hello World");
    }
}
