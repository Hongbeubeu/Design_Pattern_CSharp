using System;
using AbstractFactory.Src.Factories;

namespace AbstractFactory.Src
{

    // The client code works with factories and products only through abstract
    // types: AbstractFactory and Abstractproduct. This lets you pass any 
    // factory or product subclass to the client code without breaking it.
    public class Client
    {
        public void Main()
        {
            // The client code can work with any concrete facory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code twith the second factory type...");
            ClientMethod(new ConcreteFacory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateproductB();

            Console.WriteLine(productB.UsefullFuntionB());
            Console.WriteLine(productB.AnotherUsefullFunctionB(productA));

        }
    }

}