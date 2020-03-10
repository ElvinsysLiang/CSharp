#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP05Loop
 * 项目描述 ：
 * 类 名 称 ：Lop01For
 * 类 描 述 ：for循环结构
 * 命名空间 ：CP05Loop
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-09 19:31:45
 * 更新时间 ：2020-03-09 19:31:45
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

namespace CP05Loop
{
    public class Lop01For
    {
        #region CP05_01：用for语句输出十次Hello World
        /*
         *  例程编号：CP05_01
         *  摘要：
         *      用for语句输出十次Hello World
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
        /// 用for语句输出十次Hello World
        /// </summary>
        public static void CP05_01()
        {
            for(int i =0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }
        }
        #endregion

        #region CP05_03：用for语句输出1-10
        /*
         *  例程编号：CP05_03
         *  摘要：
         *      用for语句输出1-10
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
        /// 用for语句输出1-10
        /// </summary>
        public static void CP05_03()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region CP05_05：用for语句输出10-1
        /*
         *  例程编号：CP05_05
         *  摘要：
         *      用for语句输出10-1
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
        /// 用for语句输出10-1
        /// </summary>
        public static void CP05_05()
        {
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region CP05_07：用for语句计算出1-10相加的和
        /*
         *  例程编号：CP05_07
         *  摘要：
         *      用for语句计算出1-10相加的和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         sum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用for语句计算出1-10相加的和
        /// </summary>
        public static void CP05_07()
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("1-10相加的结果是：" + sum);
        }
        #endregion

        #region CP05_09：用for语句计算出1-100相加的和
        /*
         *  例程编号：CP05_09
         *  摘要：
         *      用for语句计算出1-100相加的和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int          sum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用for语句计算出1-100相加的和
        /// </summary>
        public static void CP05_09()
        {
            int sum = 0;
            for(int i = 100; i > 0; i--)
            {
                sum += i;
            }
            Console.WriteLine("1-100相加的结果是：{0}", sum);
        }
        #endregion

        #region CP05_11：用for语句计算出1-100的偶数和
        /*
         *  例程编号：CP05_11
         *  摘要：
         *      用for语句计算出1-100的偶数和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         sum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用for语句计算出1-100的偶数和
        /// </summary>
        public static void CP05_11()
        {
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("1-100的偶数和是：" + sum);
        }
        #endregion

        #region CP05_13：用for语句计算出1-100的奇数和
        /*
         *  例程编号：CP05_13
         *  摘要：
         *      用for语句计算出1-100的奇数和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iSum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用for语句计算出1-100的奇数和
        /// </summary>
        public static void CP05_13()
        {
            int iSum = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    iSum += i;
                }
            }
            Console.WriteLine("1-100的奇数和是：" + iSum);
        }
        #endregion

        #region CP05_15：用for语句求5的阶乘
        /*
         *  例程编号：CP05_15
         *  摘要：
         *      用for语句求5的阶乘
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iFactorial
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用for语句求5的阶乘
        /// </summary>
        public static void CP05_15()
        {
            int iFactorial = 1;
            for(int i = 1; i <= 5; i++)
            {
                iFactorial *= i;
            }
            Console.WriteLine("5的阶乘是：" + iFactorial);
        }
        #endregion

        #region CP05_17：用for语句打印九九乘法表
        /*
         *  例程编号：CP05_17
         *  摘要：
         *      用for语句打印九九乘法表
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
        /// 用for语句打印九九乘法表
        /// </summary>
        public static void CP05_17()
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("{0} * {1} = {2}\t", j, i, j * i);
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region CP05_18：用for语句，在1——1000中满足条件的数，并输出到控制台
        /*
         *  例程编号：CP05_18
         *  摘要：
         *      用for语句，在1——1000中满足条件的数，并输出到控制台
         *  说明：
         *      1）x % 3 = 2
         *      2）x % 5 = 3
         *      3）x % 7 = 2
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用for语句，在1——1000中满足条件的数，并输出到控制台
        /// </summary>
        public static void CP05_18()
        {
            for(int i = 1; i <= 1000; i++)
            {
                if ((i % 3 == 2) && (i % 5 == 3) && (i % 7 == 2))
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion


    }
}