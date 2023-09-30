namespace CSharp30._09.product
{
    public abstract class ProductBase
    {
        protected string Info;

        protected ProductBase(int info)
        {
            Info = info.ToString();
        }


        public string GetInfo() => Info;
    }

    public abstract class AbstractProductA : ProductBase
    {
        protected AbstractProductA(int info) : base(info){}

        public abstract void A();
    }

    public abstract class AbstractProductB : ProductBase
    {
        protected AbstractProductB(int info) : base(info){}

        public abstract void B(AbstractProductA productA);
    }
}