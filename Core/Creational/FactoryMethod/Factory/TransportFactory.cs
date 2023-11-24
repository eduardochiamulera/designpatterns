using Core.Creational.FactoryMethod.Implementations;
using Core.Creational.FactoryMethod.Interfaces;
using static Core.Enumerations.Enumerations;

namespace Core.Creational.FactoryMethod.Factory
{
	public class TransportFactory : ITransportFactory
	{
		public ITransport CreateInstance(Transport transportType)
		{
			switch (transportType)
			{
				case Transport.Plane:
					return new Plane();
				case Transport.Ship:
					return new Ship();
				case Transport.Car:
					return new Car();
				case Transport.Truck:
					return new Truck();
				default:
					throw new ArgumentException($"Invalid type for ${nameof(Transport)}");
			}
		}
	}
}
