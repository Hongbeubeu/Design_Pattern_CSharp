using AbstractFactory.Src.Products;

namespace AbstractFactory.Src.Factories
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract 
    // product, while inside the method a concrete product is instantiated
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateproductB()
        {
            return new ConcreteProductB1();
        }
    }
}