using System;

namespace CSharp30._09.product
{
    public class ProductA1 : AbstractProductA
    { 
        public ProductA1(int info): base(info){}

        public override void A()
        {
            Info = (Convert.ToInt32(Info) * 2).ToString();
        }
    }

    public class ProductA2 : AbstractProductA
    {
        public ProductA2(int info) : base(info){}
        
        public override void A()
        {
            Info += Info;
        }
        
    }
    
    public class ProductB1 : AbstractProductB
    {
        public ProductB1(int info): base(info){}

        public override void B(AbstractProductA productA)
        {
            Info = (Convert.ToInt32(Info) + Convert.ToInt32(productA.GetInfo())).ToString();
        }
    }
    
    public class ProductB2 : AbstractProductB
    {
        public ProductB2(int info): base(info){}

        public override void B(AbstractProductA productA)
        {
            Info += productA.GetInfo();
        }
    }
}