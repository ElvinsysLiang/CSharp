#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP04Branch
 * 项目描述 ：
 * 类 名 称 ：Bch02Switch
 * 类 描 述 ：switch分支结构
 * 命名空间 ：CP04Branch
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-09 19:32:47
 * 更新时间 ：2020-03-09 19:32:47
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

namespace CP04Branch
{
    public class Bch02Switch
    {

        #region CP04_03：switch语句的2个练习
        /*
         *  例程编号：CP04_03
         *  摘要：
         *      switch语句的2个练习
         *  说明：
         *      1）
         *  步骤：
         *      1）键盘输入1~7，输出星期几
         *      2）键盘输入月份，输出季节
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iDay
         *                  int         iMonth
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */

        /// <summary>
        /// switch语句的2个练习
        /// </summary>
        public static void CP04_03()
        {
            int iDay, iMonth;

            //键盘输入1~7，输出星期几
            Console.Write("请输入1~7，判断星期几：");
            iDay = Convert.ToInt32(Console.ReadLine());
            switch (iDay)
            {
                case 1:
                    Console.WriteLine("星期一");
                    break;
                case 2:
                    Console.WriteLine("星期二");
                    break;
                case 3:
                    Console.WriteLine("星期三");
                    break;
                case 4:
                    Console.WriteLine("星期四");
                    break;
                case 5:
                    Console.WriteLine("星期五");
                    break;
                case 6:
                    Console.WriteLine("星期六");
                    break;
                case 7:
                    Console.WriteLine("星期日");
                    break;
                default:
                    Console.WriteLine("输入的信息有误");
                    break;
            }
            Forms.Cut();

            //键盘输入月份，输出季节
            Console.Write("请输入月份，判断季节：");
            iMonth = Convert.ToInt32(Console.ReadLine());
            switch (iMonth)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("{0}月是春季", iMonth);
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("{0}月是夏季", iMonth);
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("{0}月是秋季", iMonth);
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("{0}月是冬季", iMonth);
                    break;
                default:
                    Console.WriteLine("输入的月份有误");
                    break;
            }
        }
        #endregion

        #region CP04_04：switch语句的选择值
        /*
         *  例程编号：CP04_04
         *  摘要：
         *      switch语句的选择值
         *  说明：
         *      1）测试的数据类型：
         *          整形：byte/short/ushort/int/uint/long/ulong
         *          浮点型：float/double/decimal
         *          char/string/bool
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */

        /// <summary>
        /// switch语句的选择值
        /// </summary>
        public static void CP04_04()
        {
            byte b = 1;
            short s = 1;
            ushort us = 1;
            int i = 1;
            uint ui = 1;
            long l = 1;
            ulong ul = 1;
            char c = 'a';
            string str = "abc";
            bool flag = true;
            //经过测试，以上所有数据类型均可作为switch语句的选择值
            switch (flag)
            {
                case true:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region CP04_05：break,continue
        /*
         *  例程编号：CP04_05
         *  摘要：
         *      break,continue
         *  说明：
         *      1）补齐以下代码
         *      for(int i = 1;i <= 10;i++)
         *      {
         *          if(i%3==0)
         *          {
         *              //补齐代码
         *          }
         *          Console.WriteLine("Hello World");
         *      }
         *  步骤：
         *      1）输出2次Hello World
         *      2）输出7次Hello World
         *      3）输出13次Hello World
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */

        /// <summary>
        /// break,continue
        /// </summary>
        public static void CP04_05()
        {
            Console.WriteLine("输出2次Hello World");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    //补充代码
                    break;
                }
                Console.WriteLine("Hello World");
            }
            Forms.Cut();

            Console.WriteLine("输出7次Hello World");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    //补充代码
                    continue;
                }
                Console.WriteLine("Hello World");
            }
            Forms.Cut();

            Console.WriteLine("输出13次Hello World");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    //补充代码
                    Console.WriteLine("Hello World");
                }
                Console.WriteLine("Hello World");
            }
            Forms.Cut();
        }
        #endregion
    }
}