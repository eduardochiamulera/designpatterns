using Core.Creational.AbstractFactory.Interfaces;

namespace Core.Creational.AbstractFactory.Implementations.Victorian
{
	public class VictorianFurniterFactory : IFurnitureFactoryMethod
	{
		public IChair CreateChair()
		{
			return new VictorianChair();
		}

		public ISofa CreateSofa()
		{
			return new VictorianSofa();
		}
	}
}
