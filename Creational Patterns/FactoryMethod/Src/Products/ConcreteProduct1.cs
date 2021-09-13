namespace FactoryMethod.Src.Products
{
    // Concrete Products provide various implementations of the Product interface.
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}