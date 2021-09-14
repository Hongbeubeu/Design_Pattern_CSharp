namespace AbstractFactory.Src.Products
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefullFuntionB()
        {
            return "the result of the product B2.";
        }

        // The variant, Product B2, is only able to work correctly with the
        // vảiant, Product A1. Nevertheles, it accepts any instance of
        // AbstractproductA as an argument.
        public string AnotherUsefullFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefullFuntionA();
            return $"The result of the B1 collaborating with the ({result})";
        }

    }
}