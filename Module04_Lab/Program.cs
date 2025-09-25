// See https://aka.ms/new-console-template for more information

using Module04_Lab.Creator;
using Module04_Lab.Transports;

namespace Module04_Lab;

internal class Program
{
    public static void Main(string[] args)
    {
        TransportFactory transportFactory = null;
        ITransport transport = null;
        Console.WriteLine("Transport type (1- car, 2- motorcycle 3- plane): ");
        int type = Convert.ToInt32(Console.ReadLine());
        switch (type)
        {
            case 1:
                transportFactory = new CarFactory();
                break;
            case 2:
                transportFactory = new MotorcycleFactory();
                break;
            case 3: 
                transportFactory = new PlaneFactory();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
        transport = transportFactory.CreateTransport();
        transport.Move();
        transport.FuelUp();
    }
    
}