using System.Security.Cryptography.X509Certificates;

public interface ISubject
{
    public void AddMeAsObserver(IObserver observer);
    public void RemoveMeAsObserver(IObserver observer);
    public void NotifyObservers();
}

public interface IObserver
{
    public string Name { get; set; }
    public void Update(ISubject subject);
}
public class Subject : ISubject
{
    public int state { get; set; }
    public List<IObserver> observers = new List<IObserver>();
    public void AddMeAsObserver(IObserver observer){observers.Add(observer);}
    public void RemoveMeAsObserver(IObserver observer) { observers.Remove(observer); }
    public void NotifyObservers()
    {
        observers.ForEach(m=>
        {
            Console.WriteLine($"Sending notification to : {m.Name}");
            m.Update(this);
        });
    }
    public void DoSomeChanges()
    {
        state = new Random().Next(0, 10);
        this.NotifyObservers();
    }

}
public class Observer: IObserver
{
    public string Name { get; set; }
    public Observer(string name)
    {
        Name = name;    
    }

    public void Update(ISubject subject)
    {
        //lets say we know which arg(subject) is being passed
        Console.WriteLine($"State has been changed to {((Subject)subject).state}");
    }
}


public static class Progam{
    public static void Main()
    {
        Subject subject = new Subject();
        Observer observerA = new Observer("A");
        Observer observerB = new Observer("B");
        subject.AddMeAsObserver(observerA);
        subject.AddMeAsObserver(observerB);
        subject.DoSomeChanges();
        subject.DoSomeChanges();
    }
}