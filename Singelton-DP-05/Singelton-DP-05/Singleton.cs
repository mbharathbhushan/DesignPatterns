using System;
using System.Collections.Generic;
using System.Text;

namespace Singelton_DP_05
{
    sealed class Singleton
    {
        private static int counter = 0;

        //private static Singleton instance = new Singleton();

        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        // Not required for eager loading
        private static readonly Object obj = new object();

        public static Singleton GetInstance
        {
            get
            {
                // Eager loading
                //return instance;


                ////    // If we have not lock this instantiation code , with multithread multiple instances may be created.
                ////    // Below Process in called Lazy loading.
                ////    if (instance == null)
                ////{
                ////    lock (obj)
                ////    {
                ////        // Checking multiple time instance null or not called as (Double check Locking).
                ////        if (instance == null)
                ////        {
                ////            instance = new Singleton();
                ////        }
                ////    }
                ////}
                ////return instance;
                return instance.Value;
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
