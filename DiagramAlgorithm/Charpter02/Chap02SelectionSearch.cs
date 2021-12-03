#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter02
* 项目描述 ：
* 类 名 称 ：Chap02SelectionSearch.cs
* 类 描 述 ：
* 命名空间 ：Charpter02
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-3 16:08
* 更新时间 ：2021-12-3 16:08
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

namespace Charpter02
{
    class Chap02SelectionSort
    {
        /*
         *  例程编号：DA02_01
         *  摘要：选择排序算法
         *  说明：
         *      1）实现并测试选择排序算法
         *  步骤：
         *      1）
         */
        public static void DA02_01()
        {
            int[] arr = { 13, 0, 41, 88, 19 };
            Console.WriteLine("arr is: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Run SelectionSort_1...");
            int[] arrNew = SelectionSort_1(arr);
            foreach (var i in arrNew)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Run SelectionSort_2...");
            arrNew = SelectionSort_2(arr);
            foreach (var i in arrNew)
            {
                Console.Write(i + " ");
            }
        }
        /// <summary>
        /// 选择排序算法_1
        /// </summary>
        /// <param name="arr">需要排序的数组</param>
        /// <returns>返回一个新的已经排序的数组</returns>
        public static int[] SelectionSort_1(int[] arr)
        {
            int[] arrNew = new int[arr.Length];
            int tempVar;
            for (int i = 0; i < arr.Length; i++)
            {
                arrNew[i] = arr[i];
            }
            for (int i = 0; i < arrNew.Length - 1; i++)
            {
                for (int j = i + 1; j < arrNew.Length; j++)
                {
                    if (arrNew[j] < arrNew[i])
                    {
                        tempVar = arrNew[j];
                        arrNew[j] = arrNew[i];
                        arrNew[i] = tempVar;
                    }
                }
            }
            return arrNew;
        }
        /// <summary>
        /// 选择排序算法_2
        /// </summary>
        /// <param name="arr">需要排序的数组</param>
        /// <returns>返回一个新的已经排序的数组</returns>

        public static int[] SelectionSort_2(int[] arr)
        {
            int[] arrNew = new int[arr.Length];
            int smallestIndex,temp;
            for(int i = 0; i < arr.Length; i++)
            {
                arrNew[i] = arr[i];
            }
            for(int i = 0; i < arrNew.Length - 1; i++)
            {
                smallestIndex = i;
                for(int j = i+1; j < arrNew.Length; j++)
                {
                    if (arrNew[smallestIndex] > arrNew[j])
                    {
                        smallestIndex = j;
                    }
                }
                if (i != smallestIndex)
                {
                    temp = arrNew[i];
                    arrNew[i] = arrNew[smallestIndex];
                    arrNew[smallestIndex] = temp;
                }
            }
            return arrNew;
        }
    }
}
