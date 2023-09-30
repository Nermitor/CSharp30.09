using CSharp30._09.product;

namespace CSharp30._09.fabric
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA(int info);

        public abstract AbstractProductB CreateProductB(int info);

    }
}