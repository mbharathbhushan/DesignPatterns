using System;

namespace Singleton_DP_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("First message");

            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("It is second message");

            Console.WriteLine();

            // SO here it voilates the singlton pattern by creating second instance for singleton.
            //Singleton.DerivedClass derivedClass = new Singleton.DerivedClass();
            //derivedClass.PrintDetails("Derived Class");

            Console.ReadLine();
        }
    }
}
