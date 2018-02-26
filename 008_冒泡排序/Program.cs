using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 5, 7, 90, 4, 6, 8, 10 };
            MySort(nums);
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        //冒泡排序，因为所有的数组都是引用类型，故不用返回值
        private static void MySort(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (nums[j]>nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
    }
}
