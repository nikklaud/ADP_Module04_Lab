using Module04_Lab.Transports;

namespace Module04_Lab.Creator;

public class BicycleCreator: TransportFactory
{
    public override ITransport CreateTransport(double speed, string model)
    {
        return new Bicycle(model, speed);
    }
}