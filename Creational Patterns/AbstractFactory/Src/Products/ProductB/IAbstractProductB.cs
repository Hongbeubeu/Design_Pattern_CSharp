namespace AbstractFactory.Src.Products
{
    // Here's the basae interface of another product. All products can 
    // interact with each other, but proper interaction is possible only between 
    // products of the same concrete variant.
    public interface IAbstractProductB
    {
        //Product B is able to do its own thing
        string UsefullFuntionB();

        // but it also can collaborate with the ProductA.

        // The Abstract Factory make sure that all products it creates are of
        // the same variant and thus, compatible.
        string AnotherUsefullFunctionB(IAbstractProductA collaborator);
    }

}