using Core.Creational.FactoryMethod.Interfaces;
using static Core.Enumerations.Enumerations;

namespace Core.Creational.FactoryMethod.Implementations
{
    public class Plane : ITransport
    {
        public string Build()
        {
            return $"{nameof(Transport.Plane)} transport";
        }
    }
}
