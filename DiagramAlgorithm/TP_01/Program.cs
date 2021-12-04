#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：TP_01
* 项目描述 ：
* 类 名 称 ：Program.cs
* 类 描 述 ：
* 命名空间 ：TP_01
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-4 10:30
* 更新时间 ：2021-12-4 10:30
* 版 本 号 ：V0.0.0.1
* ======================================
* 历史更新记录
* 版 本 号：V         
* 修改时间：         
* 修改人：
* 修改内容：
* ======================================
*******************************************************************
* Copyright @ NEETJIN 2021-2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion << 版 本 注 释 >>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrQS = { 0, 48, 24, 12, 13, 85 };
            int[] arrBS = { 0, 12, 13, 24, 48, 85 };
            Console.WriteLine("arr is:");
            foreach (var i in arrBS)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //测试实例01：二分查找
            Console.WriteLine("Test BinarySearch...");
            int guess = 13;
            Console.WriteLine($"guess number:{guess},position is {BinarySearch(arrBS, guess)}.");
            Console.ReadKey();

        }
        public static int BinarySearch(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid, guess;
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = arr[mid];
                if (guess == item)
                {
                    return mid;
                }
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
