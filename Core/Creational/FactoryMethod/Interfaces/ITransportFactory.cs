using static Core.Enumerations.Enumerations;

namespace Core.Creational.FactoryMethod.Interfaces
{
    public interface ITransportFactory
    {
        ITransport CreateInstance(Transport transportType);
    }
}
