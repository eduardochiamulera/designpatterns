using Core.Creational.AbstractFactory.Implementations.Modern;
using Core.Creational.AbstractFactory.Implementations.Victorian;
using Core.Creational.AbstractFactory.Interfaces;
using static Core.Enumerations.Enumerations;

namespace Core.Creational.AbstractFactory
{
	public sealed class FurnitureFactory : IFurniteFactory
	{
		public IFurnitureFactoryMethod CreateFactory(Forniture furniture)
		{
			switch (furniture)
			{
				case Forniture.Victorian:
					return new VictorianFurniterFactory();
				case Forniture.Modern:
					return new ModernFurnitureFactory();
				default:
					throw new ArgumentOutOfRangeException(nameof(furniture), furniture, null);
			}
		}
	}
}
