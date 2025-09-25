namespace Module04_Lab.Transports;

public class Motorcycle: ITransport
{
    private string _model;
    private double _speed;

    public Motorcycle(string model, double speed)
    {
        this._model = model;
        this._speed = speed;
    }
    public void Move()
    {
        Console.WriteLine("Motorcycle Move");
    }

    public void FuelUp()
    {
        Console.WriteLine("Motorcycle Fuel Up");
    }
}