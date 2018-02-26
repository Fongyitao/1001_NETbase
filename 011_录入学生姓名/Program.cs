using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_录入学生姓名
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string name = string.Empty;
            do
            {
                Console.WriteLine("输入学生姓名：");
                name = Console.ReadLine();
                list.Add(name);
            } while (name.ToLower() != "quit");
            list.RemoveAt(list.Count - 1);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
