#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP06Method
 * 项目描述 ：
 * 类 名 称 ：Mt01Method
 * 类 描 述 ：方法的基本用法
 * 命名空间 ：CP06Method
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-14 16:39:25
 * 更新时间 ：2020-03-14 16:39:25
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP06Method
{
    public class Mt01Method
    {
        #region CP06_01：方法的形参和实参
        /*
         *  例程编号：CP06_01
         *  摘要：
         *      方法的形参和实参
         *  说明：
         *      1）形参无法改变实参的例程
         *      2）形参能改变实参的例程
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar
         *                  int[]       iArray
         *  方法：
         *      修饰符         返回值类型    方法名          参数类型    备注
         *                      void        Change_1        int
         *                      int         Change_2        int
         *                      void        ChangeArray     int[]
         */
        /// <summary>
        /// 方法的形参和实参
        /// </summary>
        public static void CP06_01()
        {
            //形参无法改变实参
            int iVar = 1;
            Console.WriteLine("用Change_1()方法改变iVar1的值");
            Console.WriteLine("现在iVar的值是：" + iVar);
            Change_1(iVar);
            Console.WriteLine("运行Change_1()方法后，iVar的值是：" + iVar);
            iVar = Change_2(iVar);
            Console.WriteLine("运行Change_2()方法后，iVar的值是：" + iVar);

            //形参改变实参
            int[] iArray = { 1 };
            Console.WriteLine("用ChangeArray()方法改变iArray的元素值");
            Console.WriteLine("现在iArray[0]的值是：" + iArray[0]);
            ChangeArray(iArray);
            Console.WriteLine("运行ChangeArray()方法后，iArray[0]的值是：" + iArray[0]);

        }
        /// <summary>
        /// 形参无法改变实参，方法1
        /// </summary>
        /// <param name="iVar1">需要改变的值</param>
        public static void Change_1(int iVar)
        {
            iVar = 2;
        }

        /// <summary>
        /// 形参无法改变实参，方法2,必须返回数据
        /// </summary>
        /// <param name="iVar">需要改变的值</param>
        /// <returns>返回改变后的值</returns>
        public static int Change_2(int iVar)
        {
            return iVar = 2;
        }

        /// <summary>
        /// 形参能改变实参，因为，实参是个引用类型数据
        /// </summary>
        /// <param name="iArray"></param>
        public static void ChangeArray(int[] iArray)
        {
            iArray[0] = 2;
        }
        #endregion

        #region CP06_02：方法的例程
        /*
         *  例程编号：CP06_02
         *  摘要：
         *      方法的例程
         *  说明：
         *      1）用户输入整形数据，如果不是整数，提示重新输入
         *      2）利用的语句：while，try...catch...
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        public static void CP06_02()
        {
            int iVar;
            Console.Write("请输入整形数据：");
            while (true)
            {
                try
                {
                    iVar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("您输入的数据是：{0}", iVar);
                    break;
                }
                catch
                {
                    Console.WriteLine("您输入的数据不是一个整形数据，请重新输入。");
                }
            }
        }
        #endregion

        #region CP06_09：方法的重载
        /*
         *  例程编号：CP06_09
         *  摘要：
         *      方法的重载
         *  说明：
         *      1）方法重载的条件：1.方法名一样；2.参数的个数或类型不一样
         *  步骤：
         *      1）方法一：2个整形变量相加，返回相加之和
         *      2）方法二：2个整形变量相加，返回两字符串相连接的字符串（无法重载）
         *      3）方法三：3个整形变量相加，返回相加之和（和方法一发生重载）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         *                  int         GetSum          int,int
         *                  string      GetSum          int,int     无法重载，方法名和参数类型或个数一样
         *                  int         GetSum          int,int,int 可以重载，参数个数不一样
         */
        /// <summary>
        /// 方法的重载
        /// </summary>
        public static void CP06_09()
        {
            //测试返回类型不同，但参数相同的方法
            //不可以。方法重载的条件是：
            //          1.方法名一样；2.参数个数或类型不相同

            Console.WriteLine("利用GetSum()方法计算 1 + 2 = " + GetSum(1, 2));
            Console.WriteLine("利用GetSum()方法计算 1 + 2 + 3 = " + GetSum(1, 2, 3));
        }

        /// <summary>
        /// 2个整形变量相加
        /// </summary>
        /// <param name="iVar_1">整形变量1</param>
        /// <param name="iVar_2">整形变量2</param>
        /// <returns>2个整形数据相加之和</returns>
        public static int GetSum(int iVar_1, int iVar_2)
        {
            return iVar_1 + iVar_2;
        }

        /// <summary>
        /// 2个整形数据的字符串连接（无法重载）
        /// </summary>
        /// <param name="iVar_1">整形变量1</param>
        /// <param name="iVar_2">整形变量2</param>
        /// <returns>2个整形数据连接的字符串</returns>
        //public static string GetSum(int iVar_1,int iVar_2)
        //{
        //    return iVar_1.ToString() + iVar_2.ToString();
        //}

        /// <summary>
        /// 3个整形变量相加(参数的个数不同，可以重载）
        /// </summary>
        /// <param name="iVar_1">整形变量1</param>
        /// <param name="iVar_2">整形变量2</param>
        /// <param name="iVar_3">整形变量3</param>
        /// <returns>2个整形数据相加之和</returns>
        public static int GetSum(int iVar_1, int iVar_2, int iVar_3)
        {
            return iVar_1 + iVar_2 + iVar_3;
        }
        #endregion

        #region CP06_10：方法递归的例程
        /*
         *  例程编号：CP06_10
         *  摘要：
         *      方法递归的例程
         *  说明：
         *      1）方法递归就是在方法里面执行自己
         *      2）注意：
         *          第一，明确方法的功能。（明确需要的条件，确定返回值和参数）
         *          第二，明确递归退出的条件。
         *          第三，找到递归的关系是
         *  步骤：
         *      1）方法1：按照用户的要求次数来输出HelloWorld
         *      2）方法2：实现n的阶乘
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// 方法递归的例程
        /// </summary>
        public static void CP06_10()
        {
            int iVar;
            Console.Write("请输入需要重复显示HelloWorld的次数：");
            try
            {
                iVar = Convert.ToInt32(Console.ReadLine());
                while (iVar < 0)
                {
                    Console.Write("阶乘必须大于或等于0，请重新输入：");
                    iVar = Convert.ToInt32(Console.ReadLine());
                }
                ShowHelloWorld(iVar);
            }
            catch
            {
                Console.WriteLine("输入的不是一个整形数字，跳过显示次数，继续执行阶乘程序...");
            }
            CP00Forms.Forms.Cut();

            Console.Write("请输入一个整形数字，就n的阶乘：");
            try
            {
                iVar = Convert.ToInt32(Console.ReadLine());
                //计算N的阶乘
                while (iVar < 0)
                {
                    Console.Write("阶乘必须大于或等于0，请重新输入：");
                    iVar = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("{0}的阶乘是：{1}", iVar, Factorial(iVar));
            }
            catch
            {
                Console.WriteLine("输入的不是一个整形数字，程序退出。");
                return;
            }
        }

        /// <summary>
        /// 按照用户输入的次数在控制台打印HelloWorld
        /// </summary>
        /// <param name="iVar">输出控制台的次数</param>
        public static void ShowHelloWorld(int iVar)
        {
            if (iVar == 0)
            {
                Console.WriteLine("显示完毕。");
                return;
            }
            Console.WriteLine("第{0}次显示：HelloWorld.",iVar);
            ShowHelloWorld(--iVar);
        }

        /// <summary>
        /// n的阶乘
        /// </summary>
        /// <param name="iVar"></param>
        /// <returns>n的阶乘</returns>
        public static int Factorial(int iVar)
        {
            if (iVar == 1 || iVar == 0)
            {
                return 1;
            }
            if (iVar == 2)
            {
                return 2;
            }
            return iVar * Factorial(iVar - 1);
        }
        #endregion


    }
}