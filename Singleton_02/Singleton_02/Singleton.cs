using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_02
{
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

        private Singleton()
        {
            counter = counter + 1;
            Console.WriteLine(counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
