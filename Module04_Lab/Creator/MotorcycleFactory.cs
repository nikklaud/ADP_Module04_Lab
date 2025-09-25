using Module04_Lab.Transports;

namespace Module04_Lab.Creator;

public class MotorcycleFactory: TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Motorcycle();
    }
}