using Core.Creational.AbstractFactory.Interfaces;

namespace Core.Creational.AbstractFactory.Implementations.Modern
{
	public sealed class ModernChair : Chair
    {
        public override string Print()
        {
            return "This is a modern chair";
        }
    }
}
