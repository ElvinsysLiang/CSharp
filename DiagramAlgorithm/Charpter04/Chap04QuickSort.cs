#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter04
* 项目描述 ：
* 类 名 称 ：Chap04QuickSort.cs
* 类 描 述 ：
* 命名空间 ：Charpter04
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-3 18:10
* 更新时间 ：2021-12-3 18:10
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

namespace Charpter04
{
    class Chap04QuickSort
    {
        /*
         *  例程编号：DA01_01
         *  摘要：简单的HelloWorld程序
         *  说明：
         *      1）求中间值的方法
         *      2）利用分而治之的思想，进行递归排序
         *  步骤：
         *      1）
         */
        public static void DA04_01()
        {

            int[] arr = { 4, 11, 53, 0, 33 };
            Console.WriteLine("arr is:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("QuickSort...");
            QuickSort(arr, 0, arr.Length - 1);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 利用基准值，把小于基准值的放左边，大于基准值的放右边
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int GetMid(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            int mid = left;
            while (left < right)
            {
                while ((left < right) && (arr[right] >= pivot))
                {
                    right--;
                }
                arr[left] = arr[right];
                while ((left < right) && (arr[left] < pivot))
                {
                    left++;
                }
                arr[right] = arr[left];
            }
            mid = left;
            arr[left] = pivot;
            return mid;
        }
        /// <summary>
        /// 利用基准值进行递归排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = GetMid(arr, left, right);
                QuickSort(arr, left, mid - 1);
                QuickSort(arr, mid + 1, right);
            }
        }
    }
}
