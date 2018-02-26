using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            //编写一个类ItcastClass该类中有一个字段_name,数据类型为字符串数组,长度为5并且有5个默认的值;要求:为ItcastClass类编写一个索引器,要求该索引器要能通过下标来访问_name中的内容。
            ItcastClass itcast = new ItcastClass();
            for (int i = 0; i < itcast.Count; i++)
            {
                Console.WriteLine(itcast[i]);
            }
            Console.ReadKey();
        }
    }
}
