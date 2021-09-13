using FactoryMethod.Src.Products;

namespace FactoryMethod.Src.Creators
{
    // Concrete Creators override the factory method in order to change the 
    // resulting product's type.
    public class ConcreteCreator1 : Creator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. this way the Creator can stay independent of concrete product class.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}