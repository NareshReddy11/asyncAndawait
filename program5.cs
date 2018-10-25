using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class program5
    {
        public static void Main()
        {
            boys().Wait();
            
        }

        static async Task  boys()
        {
            await girls();
            Console.WriteLine("Today is "+DateTime.Now);
            Console.WriteLine("The current time is "+DateTime.Now.TimeOfDay);
            Console.WriteLine("The current temperature is 25 degrees.");
        }

        static async Task girls()
        {
            await Task.Delay(10000); 
            Console.WriteLine("Sorry for the delay. ");
        }
    }
}
