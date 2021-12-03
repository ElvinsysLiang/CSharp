#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter01
* 项目描述 ：
* 类 名 称 ：BinarySearch.cs
* 类 描 述 ：
* 命名空间 ：Charpter01
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-3 13:34
* 更新时间 ：2021-12-3 13:34
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

namespace Charpter01
{
    #region DA01_01：二分查找算法
    /*
     *  例程编号：DA01_01
     *  摘要：二分查找算法
     *  说明：
     *      1）实现并测试二分查找算法
     *  步骤：
     *      1）
     */
    #endregion
    class Chap01BinarySearch
    {
        public static void DA01_01()
        {
            int[] arr = { 11, 44, 53, 75, 99 };
            Console.WriteLine("the arr is:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int item = 75;
            Console.WriteLine($"position of {item} is {BinarySearch(arr, item)}");
        }

        /// <summary>
        /// 二分查找算法
        /// </summary>
        /// <param name="arr">数组名</param>
        /// <param name="item">要查找的元素</param>
        /// <returns>该元素所在位置</returns>
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
