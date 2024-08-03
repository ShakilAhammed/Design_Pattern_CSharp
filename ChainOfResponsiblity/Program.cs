abstract class SupportHandler{
    public SupportHandler? nextHandler = null;
    public abstract void Handle();
    public void Proceed(){
        this.Handle();
        if(this.nextHandler != null) this.nextHandler.Proceed();
    }
}

class LevelOneSupport : SupportHandler{
    public override void Handle()
    {
        Console.WriteLine("Level one support");
    }
}

class LevelTwoSupport : SupportHandler{
    public override void Handle()
    {
        Console.WriteLine("Level two support");
    }
}

static class Program{
    public static void Main(){
        LevelOneSupport levelOneSupport = new LevelOneSupport();
        LevelTwoSupport levelTwoSupport = new LevelTwoSupport();
        levelOneSupport.nextHandler = levelTwoSupport;
        levelOneSupport.Proceed();
    }
}