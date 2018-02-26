using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_字符串中某个字符串出现次数
{
    class Program
    {
        static void Main(string[] args)
        {
            //需求:统计下面字符串中"咳嗽"出现的次数,以及每次出现的索引.扩展:统计出每个字符出现的次数.
            string str = "患者: “大夫,我咳嗽得很重。” 大夫: “你多大年纪?”  患者: “七十五岁。” 大夫: “二十岁咳嗽吗?”  患者: “不咳嗽。”  大夫: “四十岁咳嗽吗?”  患者: “也不咳嗽。”大夫:“那现在不咳嗽,还要等到什么时候咳嗽?”";
            string target = "咳嗽";
            int count = 0;//计数器
            for (int index = 0; (index = str.IndexOf(target, index)) != -1; index += target.Length)
            {
                count++;
                Console.WriteLine("{0}第{1}次出现的位置是{2}", target, count, index);
            }
            Console.ReadKey();
        }
    }
}
