using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_求1_100之间整数和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100 ; i++)
            {
                sum += i;
            }
            Console.WriteLine("和是：{0}", sum);
            Console.ReadKey();
        }
    }
}
