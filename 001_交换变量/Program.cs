using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5;

            Console.WriteLine("a = {0},b = {1}",a,b);
            Swap(ref a, ref b);
            Console.WriteLine("交换后");
            Console.WriteLine("a = {0},b = {1}", a, b);
            Console.ReadKey();
        }

        private static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;

            
        }
    }
}
