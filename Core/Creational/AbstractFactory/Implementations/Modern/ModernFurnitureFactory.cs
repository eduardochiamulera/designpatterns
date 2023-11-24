using Core.Creational.AbstractFactory.Interfaces;

namespace Core.Creational.AbstractFactory.Implementations.Modern
{
    public class ModernFurnitureFactory : IFurnitureFactoryMethod
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
