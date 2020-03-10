﻿#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP05Loop
 * 项目描述 ：
 * 类 名 称 ：Lop02While
 * 类 描 述 ：while语句的练习
 * 命名空间 ：CP05Loop
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-10 13:08:00
 * 更新时间 ：2020-03-10 13:08:00
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
    public class Lop02While
    {
        #region CP05_02：用while语句输出十次Hello World
        /*
         *  例程编号：CP05_02
         *  摘要：
         *      用while语句输出十次Hello World
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用while语句输出十次Hello World
        /// </summary>
        public static void CP05_02()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Hello World");
                i++;
            }
        }
        #endregion

        #region CP05_04：用while语句输出1-10
        /*
         *  例程编号：CP05_04
         *  摘要：
         *      用while语句输出1-10
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
        /// 用while语句输出1-10
        /// </summary>
        public static void CP05_04()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        #endregion

        #region CP05_06：用while语句输出10-1
        /*
         *  例程编号：CP05_06
         *  摘要：
         *      用while语句输出10-1
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
        /// 用while语句输出10-1
        /// </summary>
        public static void CP05_06()
        {
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        #endregion

        #region CP05_08：用while语句计算出1-10相加的和
        /*
         *  例程编号：CP05_08
         *  摘要：
         *      用while语句计算出1-10相加的和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *                  int         iSum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用while语句计算出1-10相加的和
        /// </summary>
        public static void CP05_08()
        {
            int i = 1;
            int sum = 0;
            while (i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("1-10相加的结果是：{0}", sum);
        }
        #endregion

        #region CP05_10：用while语句计算出1-100相加的和
        /*
         *  例程编号：CP05_10
         *  摘要：
         *      用while语句计算出1-100相加的和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *                  int         sum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用while语句计算出1-100相加的和
        /// </summary>
        public static void CP05_10()
        {
            int i = 100;
            int sum = 0;
            while (i > 0)
            {
                sum += i;
                i--;
            }
            Console.WriteLine("1-100相加的结果是：{0}", sum);
        }
        #endregion

        #region CP05_12：用while语句计算出1-100的偶数和
        /*
         *  例程编号：CP05_12
         *  摘要：
         *      用while语句计算出1-100的偶数和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *                  int         sum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用while语句计算出1-100的偶数和
        /// </summary>
        public static void CP05_12()
        {
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine("1-100的偶数和是：" + sum);
        }
        #endregion

        #region CP05_14：用while语句计算出1-100的奇数和
        /*
         *  例程编号：CP05_14
         *  摘要：
         *      用while语句计算出1-100的奇数和
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *                  int         iSum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用while语句计算出1-100的奇数和
        /// </summary>
        public static void CP05_14()
        {
            int i = 1, iSum = 0;
            while (i <= 100)
            {
                if (i % 2 == 1)
                {
                    iSum += i;
                }
                i++;
            }
            Console.WriteLine("1-100的奇数和是：" + iSum);
        }
        #endregion

        #region CP05_16：用while语句求5的阶乘
        /*
         *  例程编号：CP05_16
         *  摘要：
         *      用while语句求5的阶乘
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *                  int         iFactorial
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用while语句求5的阶乘
        /// </summary>
        public static void CP05_16()
        {
            int i = 1, iFactorial = 1;
            while (i <= 5)
            {
                iFactorial *= i;
                i++;
            }
            Console.WriteLine("5的阶乘是：" + iFactorial);
        }
        #endregion

        #region CP05_19：用while语句，在1——1000中满足条件的数，并输出到控制台
        /*
         *  例程编号：CP05_19
         *  摘要：
         *      用while语句，在1——1000中满足条件的数，并输出到控制台
         *  说明：
         *      1）x % 3 = 2
         *      2）x % 5 = 3
         *      3）x % 7 = 2
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用while语句，在1——1000中满足条件的数，并输出到控制台
        /// </summary>
        public static void CP05_19()
        {
            int i = 1;
            while (i <= 1000)
            {
                if ((i % 3 == 2) && (i % 5 == 3) && (i % 7 == 2))
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        #endregion

        #region CP05_20：while语句和do while语句的区别
        /*
         *  例程编号：CP01_01
         *  摘要：
         *      while语句和do while语句的区别
         *  说明：
         *      1）while语句，先对条件进行判断，再执行语句体
         *      2）do while语句，先执行语句体，再对条件进行判断
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         i
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// while语句和do while语句的区别
        /// </summary>
        public static void CP05_20()
        {
            int i;
            Console.WriteLine("演示 while语句的效果");
            Console.WriteLine("执行初始化...");
            i = 0;
            while (i < 0)
            {
                i++;
            }
            if (i == 0)
            {
                Console.WriteLine("因为i不符合判断条件，因此，while语句并没有执行");
            }
            else
            {
                Console.WriteLine("执行了while语句");
            }
            Console.WriteLine("i = " + i);
            Forms.Cut();

            Console.WriteLine("演示 do while语句的效果");
            Console.WriteLine("执行初始化...");
            i = 0;
            do
            {
                i++;
            } while (i < 0);
            if (i == 0)
            {
                Console.WriteLine("因为i不符合判断条件，因此，while语句并没有执行");
            }
            else
            {
                Console.WriteLine("执行了while语句");
            }
            Console.WriteLine("i = " + i);

        }
        #endregion


    }
}