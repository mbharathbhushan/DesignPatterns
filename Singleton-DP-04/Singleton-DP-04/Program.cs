using System;
using System.Threading.Tasks;

namespace Singleton_DP_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Parallel.Invoke(
                () => PrintEmployeeInfo(),
                () => PrintStudentInfo());
            Console.ReadLine();
        }

        private static void PrintEmployeeInfo()
        {
            Singleton printEmployeeDetails = Singleton.GetInstance;
            printEmployeeDetails.PrintDetails("Employee Details");
        }

        private static void PrintStudentInfo()
        {
            Singleton printStudentDetails = Singleton.GetInstance;
            printStudentDetails.PrintDetails("Student Details");
        }
    }
}
