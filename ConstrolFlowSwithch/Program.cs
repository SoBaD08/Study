using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrolFlowSwithch
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Avetis":
                    Console.WriteLine("This is my name.");
                    break;  // 브레이크가 여기 없으면 위 조건을 만족하여 아래 브레이크의 결과를 보여준다.
                case "Visual Studio":
                    Console.WriteLine("This is my IDE.");
                    break;
                default:
                    Console.WriteLine("This is no match.");
                    break;

            }
        }
    }
}
