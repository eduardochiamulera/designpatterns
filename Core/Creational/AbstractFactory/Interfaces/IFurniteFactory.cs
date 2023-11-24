using static Core.Enumerations.Enumerations;

namespace Core.Creational.AbstractFactory.Interfaces
{
	public interface IFurniteFactory
	{
		IFurnitureFactoryMethod CreateFactory(Forniture furniture);
	}
}
