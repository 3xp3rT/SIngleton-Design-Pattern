using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
   public sealed class Calculator
    {
        int i = 1;
        private Calculator()
        {
            Console.WriteLine(i);
            i++;
        }
        private static Calculator instance = null;
        public static  Calculator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculator();
                }
                return instance;
            }
        }
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }
        public double Addition()
        {
            return ValueOne + ValueTwo;
        }
    }
}
