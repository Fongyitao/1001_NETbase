using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_判断质数
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入要判断的数：");
                string line = Console.ReadLine();
                int num;
                if (int.TryParse(line,out num))
                {
                    if (num > 0)
                    {
                        Console.WriteLine(Prime(num));
                    }
                    else
                    {
                        Console.WriteLine("请输入正整数");
                    }
                }
                else if (line.ToLower() == "quit")
                {
                    break;
                }
                
            }
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
                for (int i = 2; i < num-1; i++)
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
