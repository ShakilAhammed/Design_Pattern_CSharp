class Program
{
    static void Main(string[] args)
    {
        //this is the implementation of authentication proxy
        IBankAccount accountProxy = new BankAccountProxy("securepassword");

        accountProxy.Deposit(100);
        accountProxy.Withdraw(30);
        Console.WriteLine($"Balance: {accountProxy.GetBalance():C}");

        //this is the implementation of lazy load proxy

        // image will not be loaded until Display is called, no image in project, trying to understand lazy load stuff
        IImage image1 = new ImageProxy("Photo1.jpg");
        IImage image2 = new ImageProxy("Photo2.jpg");

        Console.WriteLine("Images are created, but not yet loaded.");

        // The images will only be loaded when Display is called
        image1.Display();  // Loads and displays Photo1.jpg
        image1.Display();  // Displays Photo1.jpg again without loading

        image2.Display();  // Loads and displays Photo2.jpg
    }
}
