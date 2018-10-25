using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program begin");
            method1();
            for(int i=0;i<500;i++)
            {
                Console.WriteLine("for loop is:" + i);
            }
            Console.ReadKey();
        }
         static async  void method1()
        {
            string value =await method2();
            Console.WriteLine("method2 ans is:" + value);
        }
        static Task<string> method2()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "sleeping 5 sec";

            });
        }
    }
}
