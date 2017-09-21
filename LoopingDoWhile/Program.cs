using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input2 = string.Empty;

            do // do while과 while 의 차이는 do 는 최소 한번은 실행 됨.
            {
                input2 = Console.ReadLine();
                Console.WriteLine("Your input is {0}.", input2);

            } while (!input2.Equals(string.Empty));
        }
    }
}
