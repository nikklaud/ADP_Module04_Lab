namespace Module04_Lab.Transports;

public class Plane: ITransport
{
    public void Move()
    {
        Console.WriteLine("Plane Moved");
    }

    public void FuelUp()
    {
        Console.WriteLine("Plane Fuel Up");
    }
}