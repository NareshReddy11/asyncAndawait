using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("code is beging");
            method1();
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("for loop:"+i);
            }
        }
         static void  method1()
        {
            string value = method2();
            Console.WriteLine("method2 ans is:"+value);
        }
        static string method2()
        {
            Thread.Sleep(5000);
            return "deley 5 sec";
        }
    }
}
