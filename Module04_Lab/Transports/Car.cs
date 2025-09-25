namespace Module04_Lab.Transports;

public class Car: ITransport
{
    private string _model;
    private double _speed;

    public Car(string model, double speed)
    {
        this._model = model;
        this._speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"Car Moved with speed: {_speed}");
    }

    public void FuelUp()
    {
        Console.WriteLine("Car Fuel Up");
    }
}