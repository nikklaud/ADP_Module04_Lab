namespace Module04_Lab.Transports;

public class Plane: ITransport
{
    private string _model;
    private double _speed;

    public Plane(string model, double speed)
    {
        this._model = model;
        this._speed = speed;
    }
    public void Move()
    {
        Console.WriteLine($"Plane Moved with speed {_speed}");
    }

    public void FuelUp()
    {
        Console.WriteLine("Plane Fuel Up");
    }
}