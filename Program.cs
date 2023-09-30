using System;
using System.IO;
using CSharp30._09.fabric;
using CSharp30._09.product;

namespace CSharp30._09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AbstractProductA pa = null;
            AbstractProductB pb = null;
            AbstractFactory factory = null;
            StreamReader input = new StreamReader(@"C:\Users\dmaty\RiderProjects\CSharp30.09\test.txt");
            
            Test(ref pa, ref pb, ref factory, ref input);
            
            input.Close();
        }

        public static void Test(
            ref AbstractProductA pa,
            ref AbstractProductB pb,
            ref AbstractFactory factory,
            ref StreamReader input
            )
        {
            if (input.ReadLine()?.Trim() == "1")
                factory = new ConcreteFactory1();
            else
                factory = new ConcreteFactory2();

            pa = factory.CreateProductA(Convert.ToInt32(input.ReadLine()));
            pb = factory.CreateProductB(Convert.ToInt32(input.ReadLine()));

            foreach (char type in input.ReadLine().Trim())
                if (type == 'A')
                    pa.A();
                else
                    pb.B(pa);
            Console.WriteLine($"ProductA.Info = {pa.GetInfo()}");
            Console.WriteLine($"ProductB.Info = {pb.GetInfo()}");
            
        }
    }
}