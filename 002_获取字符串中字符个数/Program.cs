using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_获取字符串中字符个数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要给字符串：");
            string line = Console.ReadLine();
            Console.WriteLine("字符串{0}中，字符个数为：{1}", line, line.Length);
            Console.ReadKey();
        }
    }
}
