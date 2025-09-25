namespace Module04_Lab.Transports;

public class Car: ITransport
{
    public void Move()
    {
        Console.WriteLine("Car Moved");
    }

    public void FuelUp()
    {
        Console.WriteLine("Car Fuel Up");
    }
}