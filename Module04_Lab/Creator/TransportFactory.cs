using Module04_Lab.Transports;

namespace Module04_Lab.Creator;

public abstract class TransportFactory
{
    public abstract ITransport CreateTransport();
}