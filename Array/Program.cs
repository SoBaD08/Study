using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 2];
            //array[0] = 1;
            //array[1] = 10;
            //array[2] = 100;
            //array[3] = 1000;
            //array[4] = 10000;

            Console.WriteLine(array.Rank); // 열과 같은 개념 
            Console.WriteLine(array.Length); // 총 데이터의 길이 int[5, 2] 이기 때문에 length는 10

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);


        }
    }
}
