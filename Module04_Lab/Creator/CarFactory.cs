using System.Xml.Schema;
using Module04_Lab.Transports;

namespace Module04_Lab.Creator;

public class CarFactory: TransportFactory
{
    
    public override ITransport CreateTransport(double speed, string model)
    {
        return new Car(model, speed);
    }
}