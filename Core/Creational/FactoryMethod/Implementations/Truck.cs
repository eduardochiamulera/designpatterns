using Core.Creational.FactoryMethod.Interfaces;
using static Core.Enumerations.Enumerations;

namespace Core.Creational.FactoryMethod.Implementations
{
    public class Truck : ITransport
    {
        public string Build()
        {
            return $"{nameof(Transport.Truck)} transport";
        }
    }
}
