namespace AbstractFactory.Src.Products
{
    // Concrete Products are created by corresponding Concrete Factories
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefullFuntionA()
        {
            return "The result of the product A1.";
        }
    }
}