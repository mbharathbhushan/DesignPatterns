using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_DP_03
{
    //public class DerivedClass : Singleton
    //{

    //}

    /// <summary>
    /// Sealed Class will prevent class inheritance
    /// </summary>
    sealed class Singleton
    {
        //private static int counter = 0;

        //public Singleton()
        //{
        //    counter = counter + 1;
        //    Console.WriteLine(counter);
        //}

        private static int counter = 0;

        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }


        //Private constructor helps us to prevent any extenal instantiation object 
        private Singleton()
        {
            counter = counter + 1;
            Console.WriteLine(counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //// In Nested Class we can inherit singleton class if we removed the sealed keyword
        //public class DerivedClass : Singleton
        //{

        //}
    }
}
