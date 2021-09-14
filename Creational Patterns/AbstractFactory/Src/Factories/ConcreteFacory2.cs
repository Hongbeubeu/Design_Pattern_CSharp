using AbstractFactory.Src.Products;

namespace AbstractFactory.Src.Factories
{
    // Each Concrete Factory has a corresponding product variant.
    public class ConcreteFacory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateproductB()
        {
            return new ConcreteProductB2();
        }
    }
}