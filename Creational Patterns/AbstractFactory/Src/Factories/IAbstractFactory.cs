
using AbstractFactory.Src.Products;

namespace AbstractFactory.Src.Factories
{
    // The Abstract Factory interface declares a set of method that return
    // different abstract products. These products are called a family and are
    // related by a high-lever theme or concept. Products of one family are
    // usually able to collaborate among themselves. A family of products may
    // have serveral variants, but the products of one variant are incompatible
    // with products of another.
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateproductB();
    }
}