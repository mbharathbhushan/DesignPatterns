using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_DP_04
{
    sealed class Singleton
    {
        private static int counter = 0;

        private static Singleton instance = null;

        private static readonly Object obj = new object();

        public static Singleton GetInstance
        {
            get
            {
                // If we have not lock this instantiation code , with multithread multiple instances may be created.
                // Below Process in called Lazy loading.
                if (instance == null)
                {
                    lock (obj)
                    {
                        // Checking multiple time instance null or not called as (Double check Locking).
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
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
