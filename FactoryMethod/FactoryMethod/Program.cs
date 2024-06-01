public interface ICar
{
    public void Drive();
}

public class BMW: ICar
{

    public void Drive()
    {
        Console.WriteLine("wow, my BMW is dancing");
    }
}

public class Van : ICar
{

    public void Drive()
    {
        Console.WriteLine("wow, my van is running");
    }
}

public abstract class CarBuilder
{
    public abstract ICar BuildCar();
}

public class BMWBuilder : CarBuilder
{
    public override ICar BuildCar()
    {
        return new BMW();
    }
}

public class VanBuilder : CarBuilder
{
    public override ICar BuildCar()
    {
        return new Van();
    }
}
class Program
{
    static void Main(string[] args)
    {

        CarBuilder carBuilder;
        //depending on demand i can call any type of car builder
        carBuilder = new BMWBuilder();
        ICar myBMW = carBuilder.BuildCar();
        myBMW.Drive();
    }
}

