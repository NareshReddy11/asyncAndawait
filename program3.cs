using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class program3
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            method3();
            Console.ReadKey();
        }

        public static async void Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 150; i++)
                {
                    Console.Write(" Method 1,");
                }
               
            });
        }


        public static void Method2()
        {
           Task.Run(()=>
            {
                Thread.Sleep(5000);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 2");
                }
            });
        }
        public static async  void method3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("method3");
                }
            });
        }
    } 
}
