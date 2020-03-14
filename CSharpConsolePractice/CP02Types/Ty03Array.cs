#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty03Array
 * 类 描 述 ：数组的例程
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-11 13:25:00
 * 更新时间 ：2020-03-11 13:25:00
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;
using CP00Forms;

namespace CP02Types
{
    public class Ty03Array
    {
        #region CP02_10：整形一维数组的动态初始化
        /*
         *  例程编号：CP02_10
         *  摘要：
         *      整形一维数组的动态初始化
         *  说明：
         *      1）动态初始化一个整形一维数组
         *      2）这个整形数组有三个元素，并给元素赋值
         *      3）用for语句打印每个元素值
         *      4）？？数组首元素，以及各元素的地址怎么打印？
         *      5）？？？在C#中有必要打印数组的地址吗？
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int[]       iArray
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
         /// <summary>
         /// 一维数组的动态初始化
         /// </summary>
         public static void CP02_10()
        {
            Console.WriteLine("动态初始化一个包含三个整形数据的一维数组...");
            int[] iArray = new int[3];

            try//给元素赋值时捕获异常
            {
                //for语句给元素赋值
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("给第{0}个元素赋值：", i);
                    iArray[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("赋值时输入的数据有误，程序退出...");
                return;
            }

            //for语句打印数组首元素地址和各元素的值
            //Console.WriteLine("数组首元素地址是：\n"+iArray);打印不了...
            Console.WriteLine("数组各元素的值为：");
            for(int i =0; i < iArray.Length; i++)
            {
                Console.Write(iArray[i]+"\t");//转义字符必须双引号括起来
            }
            Console.WriteLine();
        }
        #endregion

        #region CP02_11：整形一维数组的静态初始化
        /*
         *  例程编号：CP02_11
         *  摘要：
         *      整形一维数组的静态初始化
         *  说明：
         *      1）静态初始化一个整形一维数组
         *      2）这个整形数组有三个元素，并给元素赋值
         *      3）用for语句打印每个元素值
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int[]       iArray
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
         /// <summary>
         /// 整形一维数组的静态初始化
         /// </summary>
         public static void CP02_11()
        {
            Console.WriteLine("静态初始一个整形一维数组，该数组的三个元素分别是：1，2，3...");
            int[] iArray = { 1, 2, 3 };
            Console.WriteLine("数组的三个元素值分别是：");
            for(int i = 0; i < 3; i ++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        #endregion

        #region CP02_12：数组的基础操作
        /*
         *  例程编号：CP02_12
         *  摘要：
         *      数组的基础操作
         *  说明：
         *      1）初始化数组
         *      2）遍历数组
         *      3）求数组元素最大值
         *      4）求数组元素最小值
         *      5）冒泡排序算法
         *      6）逆序排序算法1
         *      7）逆序排序算法2
         *      8）根据索引值找元素值
         *      9）根据元素值找索引值
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int[]       iArray
         *  方法：
         *      修饰符      返回值类型    方法名      参数1类型  参数2类型  备注
         *                  int[]        InitArray   int                  初始化一个整形一维数组
         *                  void         PrintArray  int[]                遍历整形一维数组
         *                  int          GetMax      int[]                求整形一维数组最大值
         *                  int          GetMin      int[]                求整形一维数组最小值
         *                  int[]        Bubble      int[]                冒泡排序算法
         *                  int[]        Reverse_1   int[]                逆序排序算法1
         *                  int[]        Reverse_2   int[]                逆序排序算法2
         *                  int          GetData     int[]      int       根据索引值找元素值
         *                  int          GetIndex    int[]      int       根据元素值找索引值
         */

        /// <summary>
        /// 数组的基础操作
        /// </summary>
        public static void CP02_12()
        {
            int iNumber;
            int[] iArray = null;
            Console.Write("请输入需要初始化的整形一维数组的大小：");
            //初始化数组
            try
            {
                iNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的不是整形数据，程序结束");
                return;
            }
            iArray = InitArray(iNumber);
            if (iArray == null)
            {
                Console.WriteLine("初始化数组失败，程序结束");
                return;
            }
            PrintArray(iArray);
            Console.WriteLine("数组最大值是：" + GetMax(iArray));
            Console.WriteLine("数组最小值是：" + GetMin(iArray));
            Forms.Cut();
            //冒泡排序
            int[] iArray_bu = Bubble(iArray);
            Console.WriteLine("对冒泡排序后的数组进行遍历...");
            PrintArray(iArray_bu);
            //倒序排序1
            int[] iArray_re_1 = Reverse_1(iArray);
            Console.WriteLine("对逆序算法1排序后的数组进行遍历...");
            PrintArray(iArray_re_1);
            //冒泡排序
            int[] iArray_re_2 = Reverse_2(iArray);
            Console.WriteLine("对逆序算法2排序后的数组进行遍历...");
            PrintArray(iArray_re_2);
            Console.WriteLine("查找3号元素，元素值为：" + GetData(iArray, 3));
            Console.WriteLine("查找元素值为3的元素，索引值为：" + GetIndex(iArray, 3));
        }

        /// <summary>
        /// 初始化数组
        /// </summary>
        /// <param name="i">数组元素数量</param>
        /// <returns>数组引用</returns>
        public static int[] InitArray(int i)
        {
            int[] iArray = null;
            if (i < 1)
            {
                Console.WriteLine("初始化失败，返回空地址。");
            }
            else
            {
                Console.WriteLine("开始初始化整形一维数组...");
                Console.WriteLine("请依次输入各元素的值：");
                iArray = new int[i];
                try
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("元素{0}：", j);
                        iArray[j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("输入的数据不是整形数据，初始化失败，返回空地址");
                    iArray = null;
                }
            }
            Forms.Cut();
            return iArray;
        }

        /// <summary>
        /// 遍历数组
        /// </summary>
        /// <param name="iArray">遍历的数组引用</param>
        public static void PrintArray(int[] iArray)
        {
            Console.Write("开始遍历整形一维数组...\n[ ");
            for (int i = 0; i < iArray.Length; i++)
            {
                if (i == iArray.Length - 1)
                {
                    Console.WriteLine(iArray[i] + " ]");
                    break;
                }
                Console.Write(iArray[i] + ", ");
            }
            Forms.Cut();
        }

        /// <summary>
        /// 求数组元素最大值
        /// </summary>
        /// <param name="iArray">求最大值的数组引用</param>
        /// <returns>返回数组元素最大值</returns>
        public static int GetMax(int[] iArray)
        {
            int iMax = iArray[0];
            if (iArray.Length > 1)
            {
                for(int i = 1; i < iArray.Length; i++)
                {
                    if (iArray[i] > iMax)
                    {
                        iMax = iArray[i];
                    }
                }
            }
            return iMax;
        }

        /// <summary>
        /// 求数组元素最小值
        /// </summary>
        /// <param name="iArray">求最小值的数组引用</param>
        /// <returns>返回数组元素最小值</returns>
        public static int GetMin(int[] iArray)
        {
            int iMin = iArray[0];
            if (iArray.Length > 1)
            {
                for (int i = 1; i < iArray.Length; i++)
                {
                    if (iArray[i] < iMin)
                    {
                        iMin = iArray[i];
                    }
                }
            }
            return iMin;
        }

        /// <summary>
        /// 冒泡排序算法
        /// </summary>
        /// <param name="iArray">冒泡排序的数组引用</param>
        /// <returns>排序后的新数组引用</returns>
        public static int[] Bubble(int[] iArray)
        {
            int iTemp;
            Console.WriteLine("创建新的数组以储存冒泡排序后的数组...");
            int[] iArray_n = new int[iArray.Length];
            for(int i = 0; i < iArray.Length; i++)
            {
                iArray_n[i] = iArray[i];
            }
            Console.WriteLine("开始进行冒泡排序...");
            for(int i = 0; i < iArray_n.Length-1; i++)
            {
                for(int j = 0; j + i < iArray_n.Length - 1; j++)
                {
                    if (iArray_n[j] > iArray_n[j + 1])
                    {
                        iTemp = iArray_n[j];
                        iArray_n[j] = iArray_n[j + 1];
                        iArray_n[j+1]=iTemp;
                    }
                }
            }
            Console.WriteLine("排序完成，返回排序后的数组引用。");
            return iArray_n;
        }

        /// <summary>
        /// 逆序排序算法1
        /// </summary>
        /// <param name="iArray">逆序排序的数组引用</param>
        /// <returns>排序后的新数组引用</returns>
        public static int[] Reverse_1(int[] iArray)
        {
            int iTemp;
            Console.WriteLine("创建新的数组以储存逆序排序后的数组...");
            int[] iArray_n = new int[iArray.Length];
            for (int i = 0; i < iArray.Length; i++)
            {
                iArray_n[i] = iArray[i];
            }
            Console.WriteLine("开始进行逆序排序...");
            for(int i = 0; i < iArray_n.Length / 2; i++)
            {
                iTemp = iArray_n[i];
                iArray_n[i] = iArray_n[iArray_n.Length - i - 1];
                iArray_n[iArray_n.Length - i - 1] = iTemp;
            }
            return iArray_n;
        }

        /// <summary>
        /// 逆序排序算法2
        /// </summary>
        /// <param name="iArray">逆序排序的数组引用</param>
        /// <returns>排序后的新数组引用</returns>
        public static int[] Reverse_2(int[] iArray)
        {
            int iTemp;
            Console.WriteLine("创建新的数组以储存逆序排序后的数组...");
            int[] iArray_n = new int[iArray.Length];
            for (int i = 0; i < iArray.Length; i++)
            {
                iArray_n[i] = iArray[i];
            }
            Console.WriteLine("开始进行逆序排序...");
            for (int i = 0, j = iArray_n.Length - 1; i<j; i++, j--)
            {
                iTemp = iArray_n[i];
                iArray_n[i] = iArray_n[j];
                iArray_n[j] = iTemp;
            }
            return iArray_n;
        }

        /// <summary>
        /// 根据索引值找元素值
        /// </summary>
        /// <param name="iArray">查找数据的数组引用</param>
        /// <param name="iIndex">数据的索引值</param>
        /// <returns>索引值对应的元素值，失败返回-1</returns>
        public static int GetData(int[] iArray, int iIndex)
        {
            int iResult = -1;
            if (iIndex < 0 || iIndex >= iArray.Length)
            {
                Console.WriteLine("输入的索引号有误，返回-1。");
            }
            else
            {
                iResult = iArray[iIndex];
            }
            return iResult;
        }

        /// <summary>
        /// 根据元素值找索引值
        /// </summary>
        /// <param name="iArray">查找索引值的数组引用</param>
        /// <param name="iData">对应的数据</param>
        /// <returns>元素值对应的索引值，失败返回-1</returns>
        public static int GetIndex(int[] iArray, int iData)
        {
            int iResult = -1;
            for(int i= 0; i < iArray.Length; i++)
            {
                if (iArray[i] == iData)
                {
                    iResult = i;
                    break;
                }
                if (i == iArray.Length - 1)
                {
                    Console.WriteLine("查找索引值失败，数组中没有对应数值的元素。");
                }
            }
            return iResult;
        }
        #endregion

        #region CP02_13：整形二维数组的动态初始化
        /*
         *  例程编号：CP02_13
         *  摘要：
         *      整形二维数组的动态初始化
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 整形二维数组的动态初始化
        /// </summary>
        public static void CP02_13()
        {
            //在栈中添加引用,在堆中申请空间，3行2列二维数组
            //int[][] iArray2 = new int[3][2];//在Java里可以这样，但C#不行
            int[][] iArray2 = new int[3][];
            iArray2[0] = new int[2];
            iArray2[1] = new int[2];
            iArray2[2] = new int[2];
            //给整形二维数组赋值
            for (int i = 0; i < iArray2.Length; i++)
            {
                for(int j = 0; j < iArray2[i].Length; j++)
                {
                    iArray2[i][j] = i;
                }
            }
            for(int i = 0; i < iArray2.Length; i++)
            {
                for (int j = 0; j < iArray2[i].Length; j++)
                {
                    Console.WriteLine("iArray2[" + i + "][" + j + "] = " + iArray2[i][j]);
                }
            }
        }
        #endregion

        #region CP02_14：整形二维数组的静态初始化
        /*
         *  例程编号：CP02_14
         *  摘要：
         *      整形二维数组的静态初始化
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 整形二维数组的静态初始化
        /// </summary>
        public static  void CP02_14()
        {
            //静态初始化一个3行2列的整形二维数组
            int[,] iArray2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //遍历
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("iArray[" + i + "][" + j + "] = " + iArray2[i, j]);
                }
            }
        }
        #endregion


    }
}