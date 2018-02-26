using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_求1_100之间质数和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (Prime(i))
                {
                    count++;
                    sum += i;
                    Console.WriteLine("第{0}个质数为：{1}",count,i);
                }
            }
            Console.WriteLine("1-100之间质数有{0}个，和为：{1}", count, sum);
            Console.ReadKey();
        }
        //质数定义为在大于1的自然数中，除了1和它本身以外不再有其他因数。
        public static bool Prime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
