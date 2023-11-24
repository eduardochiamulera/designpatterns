using Core.Creational.AbstractFactory.Interfaces;

namespace Core.Creational.AbstractFactory.Implementations.Modern
{
	public sealed class ModernSofa : Sofa
	{
        public override string Print()
        {
            return "This is a modern sofa";
        }
    }
}
