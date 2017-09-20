using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBooks = 1;
            string myName = "Avetis";
            bool IsCompatible = true;
            string number = "2";
            int numberConverted = Convert.ToInt32(number);

            Console.WriteLine(countOfBooks);
            Console.WriteLine(myName);
            Console.WriteLine(IsCompatible);
            Console.WriteLine(number);
            Console.WriteLine(numberConverted);
        }
    }
}
