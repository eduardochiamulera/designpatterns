using Core.Creational.AbstractFactory.Interfaces;

namespace Core.Creational.AbstractFactory.Implementations.Victorian
{
	public sealed class VictorianSofa : Sofa
	{
		public override string Print()
		{
			return "This is an victorian sofa";
		}
	}
}
