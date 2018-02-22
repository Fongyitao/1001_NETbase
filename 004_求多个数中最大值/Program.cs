using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_求多个数中最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            string line = string.Empty;
            do
            {
                Console.WriteLine("请输入要比较的数（quit结束输入）：");
                line = Console.ReadLine();
                double d;
                if (double.TryParse(line,out d))
                {
                    list.Add(d);
                }else
                {
                    if (line != "quit")
                    {
                        Console.WriteLine("请输入数字");
                    }
                }

            } while (line.ToLower() != "quit");
            
            double[] ds = list.ToArray();
            double max = GetMax(ds);
            Console.WriteLine("较大值是{0}", max);
            Console.ReadKey();
        }

        private static double GetMax(params double[] pms)
        {
            double max = pms[0];
            for (int i = 1; i < pms.Length; i++)
            {
                if (max<pms[i])
                {
                    max = pms[i];
                }
            }
            return max;
        }
    }
}
