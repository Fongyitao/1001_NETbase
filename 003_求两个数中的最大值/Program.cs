using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_求两个数中的最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("求两个数中的最大值：");
            Console.WriteLine("请输入第一个数：");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            double d2 = Convert.ToDouble(Console.ReadLine());

            double max = GetMax(d1, d2);
            Console.WriteLine("较大值是{0}",max);
            Console.ReadKey();
        }

        private static double GetMax(double d1, double d2)
        {
            return d1 > d2 ? d1 : d2;
        }
    }
}
