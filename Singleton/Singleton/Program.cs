using System.Reflection.Metadata.Ecma335;

public sealed class Singleton
{
    private static Singleton instance = new Singleton();
	private Singleton()
	{

	}

	public static Singleton Instance {
		get
		{
			return instance;
		}
	}

	//do something
	public void DoSomething()
	{
		Console.WriteLine("Doing.........");
	}
}

public sealed class ThreadSafetySingleton
{
	//Lazy has lock implementation inside while creating the object. so we can use it efficiently to make it thread safe
	private static Lazy<ThreadSafetySingleton> threadSafeInstance = new Lazy<ThreadSafetySingleton>(new ThreadSafetySingleton());
	private ThreadSafetySingleton() { }

	public static ThreadSafetySingleton Instance { get { return threadSafeInstance.Value;} }

	//do something
	public void DoSomething()
	{
		Console.WriteLine("Doing..........");
	}
}