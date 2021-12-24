#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：TP_00
* 项目描述 ：
* 类 名 称 ：Program.cs
* 类 描 述 ：
* 命名空间 ：TP_00
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-3 12:11
* 更新时间 ：2021-12-3 12:11
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
using DA00Forms;


namespace TP_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Title("something test...");
            Forms.Title("Please look the TP_01!");
            Console.ReadKey();
        }

        /// <summary>
        /// 001.二分查找
        /// </summary>
        /// <param name="arr">整形一维数组</param>
        /// <param name="var">查找的数据项</param>
        /// <returns></returns>
        static int SearchBinary(int[] arr, int var)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid, guess;
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = arr[mid];
                if (guess == var)
                {
                    return mid;
                }
                if (guess > var)
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

        /// <summary>
        /// 002.选择排序
        /// </summary>
        /// <param name="arr">整形一维数组</param>
        /// <returns></returns>
        static int[] SelectionSort(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int smallestIndex, smallestVar;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = 0; i < newArr.Length - 1; i++)
            {
                smallestVar = newArr[i];
                smallestIndex = i;
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (smallestVar > newArr[j])
                    {
                        smallestVar = newArr[j];
                        smallestIndex = j;
                    }
                }
                newArr[smallestIndex] = newArr[i];
                newArr[i] = smallestVar;
            }
            return newArr;
        }

        /// <summary>
        /// 递归（阶乘）
        /// </summary>
        /// <param name="n">n阶阶乘</param>
        /// <returns></returns>
        static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        /// <summary>
        /// 004.快速排序（获取参考值）
        /// </summary>
        /// <param name="arr">整形一维数组</param>
        /// <param name="left">起始位索引</param>
        /// <param name="right">结束位索引</param>
        /// <returns></returns>
        static int GetMid(int[] arr, int left, int right)
        {
            int leftIndex = left;
            int rightIndex = right;
            int pivote = arr[leftIndex];
            while (leftIndex < rightIndex)
            {
                while ((leftIndex < rightIndex) && (arr[rightIndex] >= pivote))
                {
                    rightIndex--;
                }
                arr[leftIndex] = arr[rightIndex];
                while ((leftIndex < rightIndex) && (arr[leftIndex] < pivote))
                {
                    leftIndex++;
                }
                arr[rightIndex] = arr[leftIndex];
            }
            arr[leftIndex] = pivote;
            return leftIndex;
        }
        /// <summary>
        /// 004.快速排序（递归）
        /// </summary>
        /// <param name="arr">整形一维数组</param>
        /// <param name="left">起始位索引</param>
        /// <param name="right">结束位索引</param>
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int midIndex = GetMid(arr, left, right);
                QuickSort(arr, left, midIndex - 1);
                QuickSort(arr, midIndex + 1, right);
            }
        }
    }
}