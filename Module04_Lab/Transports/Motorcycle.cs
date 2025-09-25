namespace Module04_Lab.Transports;

public class Motorcycle: ITransport
{
    public void Move()
    {
        Console.WriteLine("Motorcycle Move");
    }

    public void FuelUp()
    {
        Console.WriteLine("Motorcycle Fuel Up");
    }
}