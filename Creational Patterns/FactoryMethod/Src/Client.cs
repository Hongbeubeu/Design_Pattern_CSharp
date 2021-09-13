using System;
using FactoryMethod.Src.Creators;

namespace FactoryMethod.Src
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: launced with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still work.\n" + creator.SomeOperation());

        }
    }
}