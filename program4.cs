using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class program4
    {
        static void Main(string[] args)
        {
            var totalAfterTax = CalculateTotalAfterTaxAsync(70);
            Synchronous();

            Console.ReadLine();
        }
        private static void Synchronous()
        {
            Console.WriteLine("Doing some synchronous work like given bellow");
            for(int i=0;i<40;i++)
            {
                Console.Write(i + ",");
            }
        }

        static async Task<float> CalculateTotalAfterTaxAsync(float value)
        {
            Console.WriteLine("Start asynchronous thread");
            var result = await Task.Run(() => value * 1.2f);
            Console.WriteLine("Finished Task. Total of "+value +"after tax of 20% is "+result);
            return result;
        }
    }
}

