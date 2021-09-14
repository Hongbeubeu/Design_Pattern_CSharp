namespace AbstractFactory.Src.Products
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefullFuntionB()
        {
            return "the result of the product B1.";
        }

        // The variant, Product B1, is only able to work correctly with the
        // vảiant, Product A1. Nevẻtheles, it accepts any íntance ò 
        // AbstractproductA as an argument.
        public string AnotherUsefullFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefullFuntionA();
            return $"The result of the B1 collaborating with the ({result})";
        }

    }
}