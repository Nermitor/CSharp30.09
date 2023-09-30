using CSharp30._09.product;

namespace CSharp30._09.fabric
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA(int info) => new ProductA1(info);

        public override AbstractProductB CreateProductB(int info) => new ProductB1(info);
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA(int info) => new ProductA2(info);

        public override AbstractProductB CreateProductB(int info) => new ProductB2(info);

    }
}