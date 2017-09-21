using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 1) continue;  
                // braching statement break or continue can be used here.  continue will not print out the line when i = 1

                Console.WriteLine("This i is {0}.", i);
            }
        }
    }
}
