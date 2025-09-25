using Module04_Lab.Transports;

namespace Module04_Lab.Creator;

public class PlaneFactory: TransportFactory
{
    public override ITransport CreateTransport(double speed, string model)
    {
        return new Plane(model, speed);
    }
}