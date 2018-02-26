using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_字符串拼接
{
    class Program
    {
        static void Main(string[] args)
        {
            //两端空格去掉,并将其中的空格替换成一个空格,最后输出结果:Hello World,你 好 世界 !
            string str = "   Hello    Wrold,你   好    世界   !     ";
            str = str.Trim();//去除前后空格
            string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string newStr = String.Join(" ", arr);//将数组元素按“ ”一个空格连接，返回一个新字符串
            Console.WriteLine(newStr);
            Console.ReadKey();
        }
    }
}
