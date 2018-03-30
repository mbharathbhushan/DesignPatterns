using System;

namespace Singleton_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ////1) Senario
            //Singleton s1 = new Singleton();
            //s1.PrintDetails("First message");

            //Singleton s2 = new Singleton();
            //s2.PrintDetails("It is second message");
            //Console.ReadLine();


            Console.WriteLine("Hello World!");

            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("First message");

            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("It is second message");
            Console.ReadLine();
        }
    }
}
