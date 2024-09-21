public class Car{
    public Transmission Transmission{ get;set; }
    public string Engine { get; set; }
    public bool HasGPS { get; set; }
    public override string ToString()
    {
        return $"Car Specifications:\nEngine: {Engine}\nTransmission: {Transmission}\nGPS Included: {HasGPS}";
    }
}

public enum Transmission{
    Auto,
    Manual
}

public interface ICarBuilder{
    ICarBuilder SetEngine(string engine);
    ICarBuilder SetTransmission(Transmission transmission);
    ICarBuilder SetGPS(bool hasGPS);
    Car Build();
}

public class SportsCarBuilder: ICarBuilder{
    private Car Car = new Car();
    public ICarBuilder SetEngine(string engine)
    {
        Car.Engine = engine;
        return this;
    }
    public ICarBuilder SetTransmission(Transmission transmission)
    {
        Car.Transmission = transmission;
        return this;
    }
    public ICarBuilder SetGPS(bool hasGPS)
    {
        Car.HasGPS = hasGPS;
        return this;
    }
    public Car Build()
    {
        return Car;
    }
}

public class BMWCarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public ICarBuilder SetEngine(string engine)
    {
        _car.Engine = engine;
        return this;
    }

    public ICarBuilder SetTransmission(Transmission transmission)
    {
        _car.Transmission = transmission;
        return this;
    }

    public ICarBuilder SetGPS(bool hasGPS)
    {
        _car.HasGPS = hasGPS;
        return this;
    }

    public Car Build()
    {
        return _car;
    }
}


public class CarDirector{
    private ICarBuilder _carBuilder;
    public CarDirector(ICarBuilder carBuilder)
    {
        _carBuilder = carBuilder;
    }
    public Car ConstructSportsCar()
    {
        return _carBuilder
            .SetEngine("V8")
            .SetTransmission(Transmission.Auto)
            .SetGPS(true)
            .Build();
    }

    public Car ConstructBMWCar()
    {
        return _carBuilder
            .SetEngine("V6")
            .SetTransmission(Transmission.Manual)
            .SetGPS(false)
            .Build();
    }
}

public static class Program{
    public static void Main(string[] args)
    {
        ICarBuilder sportsCarBuilder = new SportsCarBuilder();
        CarDirector carDirector = new CarDirector(sportsCarBuilder);
        Car sportsCar = carDirector.ConstructSportsCar();
        Console.WriteLine("Sports Car Built:");
        Console.WriteLine(sportsCar.ToString());

        ICarBuilder bmwCarBuilder = new BMWCarBuilder();
        carDirector = new CarDirector(bmwCarBuilder);
        Car bmwCar = carDirector.ConstructBMWCar();
        Console.WriteLine("\nBMW Car Built:");
        Console.WriteLine(bmwCar.ToString());

    }
}
