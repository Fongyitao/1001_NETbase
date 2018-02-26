using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_反转字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //将字符串数组{"中国","American","Tokyo","Paris","韩国","土耳其"}中的内容反转,然后输出反转后的数组.不能用数组的Reverse()方法.
            string[] msg = { "中国", "American", "Tokyo", "Paris", "韩国", "土耳其" };
            MyReverse(msg);
            foreach (string item in msg)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void MyReverse(string[] msg)
        {
            for (int i = 0; i < msg.Length/2; i++)
            {
                string temp = msg[i];
                msg[i] = msg[msg.Length-i-1];
                msg[msg.Length - i - 1] = temp;
            }
        }
    }
}
