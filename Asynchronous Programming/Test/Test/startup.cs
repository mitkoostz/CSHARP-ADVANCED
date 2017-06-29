using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test
{
    class startup
    {
        public static void Main()
        {

            var thread = new Thread( () =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    i = i + i;
                }
            }
            );

            thread.Start();

            while (true)
            {
                Console.ReadLine();
            }
           

        }
    }
}
