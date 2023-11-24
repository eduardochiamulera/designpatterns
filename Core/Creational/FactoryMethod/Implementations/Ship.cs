using Core.Creational.FactoryMethod.Interfaces;
using static Core.Enumerations.Enumerations;

namespace Core.Creational.FactoryMethod.Implementations
{
    public class Ship : ITransport
    {
        public string Build()
        {
            return $"{nameof(Transport.Ship)} transport";
        }
    }
}
