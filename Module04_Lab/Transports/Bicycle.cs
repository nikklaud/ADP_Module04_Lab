namespace Module04_Lab.Transports;

public class Bicycle: ITransport
{
    private string _model;
    private double _speed;

    public Bicycle(string model, double speed)
    {
        this._model = model;
        this._speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"Bicycle is moving with speed: {_speed}");
    }

    public void FuelUp()
    {
        Console.WriteLine("The bike won't fuel up, don't violate the principles of SOLID");
    }
}