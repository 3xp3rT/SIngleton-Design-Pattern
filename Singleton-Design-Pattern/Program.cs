using System;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Instance.ValueOne = 10.5;
            Calculator.Instance.ValueTwo = 5.5;
            Console.WriteLine("Addition : " + Calculator.Instance.Addition());
            
            Console.WriteLine("\n----------------------\n");
            Calculator.Instance.ValueOne = 20.0;
            Calculator.Instance.ValueTwo = 10.5;
            Console.WriteLine("Addition : " + Calculator.Instance.Addition());
            Console.WriteLine("\n----------------------\n");
            Calculator.Instance.ValueOne = 10.0;
            Calculator.Instance.ValueTwo = 15.5;
            Console.WriteLine("Addition : " + Calculator.Instance.Addition());

            Console.ReadLine();
        }
    }
}
