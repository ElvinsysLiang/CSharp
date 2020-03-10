#region << 版 本 注 释 >>
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

        #region CP05_21：用户名密码检验程序
        /*
         *  例程编号：CP05_21
         *  摘要：
         *      用户名密码检验程序
         *  说明：
         *      1）用到循环结构，输入错误三次就退出
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用户名密码检测程序
        /// </summary>
        public static void CP05_21()
        {
            string sUserName = "";
            string sPwd = "";
            int i = 0;
            Console.WriteLine("请输入用户名和密码");
            Console.Write("用户名：");
            sUserName = Console.ReadLine();
            Console.Write("密码：");
            sPwd = Console.ReadLine();
            while (i < 3)
            {
                if (sUserName != "Admin" && sPwd != "8888")
                {
                    Console.Write("输入的用户名和密码都有误");
                }
                else if (sUserName != "Admin")
                {
                    Console.Write("用户名输入有误");
                }
                else if (sPwd != "8888")
                {
                    Console.Write("密码输入有误");
                }
                else
                {
                    Console.WriteLine("用户名和密码输入正确");
                    break;
                }
                i++;
                if (i == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("输入三次都错误，拿不到SSR了，程序强制退出");
                    return;
                }
                else
                {
                    Console.WriteLine("，请重新输入");
                }
                Console.Write("用户名：");
                sUserName = Console.ReadLine();
                Console.Write("密码：");
                sPwd = Console.ReadLine();

            }
            Console.WriteLine("恭喜，拿到了一张SSR");
        }
        #endregion

        #region CP05_22：打印用户输入的整形数据的两倍，按q结束程序
        /*
         *  例程编号：CP05_22
         *  摘要：
         *      打印用户输入的数字的两倍，按q结束程序
         *  说明：
         *      1）用while语句进行循环输入输出
         *      2）利用异常捕获检测用户输入的非整形数据
         *      3）利用if...else...语句判断是否按q
         *      4）用户输入的是字符串，因此要对数据进行转换
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  string      strInteger
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 打印用户输入的数字的两倍，按q结束程序
        /// </summary>
        public static void CP05_22()
        {
            string strInteger = "";
            while (true)
            {
                Console.WriteLine("请输入一个整形的数据，控制台会打印该数据的两倍，退出按'q'");
                strInteger = Console.ReadLine();
                if (strInteger != "q")
                {
                    try
                    {
                        Console.WriteLine(strInteger + "的两倍是" + Convert.ToInt32(strInteger) * 2);
                    }
                    catch
                    {
                        Console.WriteLine("输入的不是整形数据，请重新输入");
                    }
                }
                else
                {
                    return;
                }
            }
        }
        #endregion

        #region CP05_23：输入三个人的成绩，并计算平均成绩
        /*
         *  例程编号：CP05_23
         *  摘要：
         *      输入三个人的成绩，并计算平均成绩
         *  说明：
         *      1）成绩必须是1-100的整数
         *      2）用while语句录入成绩并计算平均值
         *      3）try...catch...检测录入的数据是否正常
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iScore
         *                  int         i
         *                  bool        bFlag
         *                  int         iSum
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 输入三个人的成绩，并计算平均成绩
        /// </summary>
        public static void CP05_23()
        {
            int iScore = 0, iSum = 0;
            bool bFlag = true;
            int i = 0;
            Console.WriteLine("请输入三个人的成绩：");
            while (i < 3)
            {
                try
                {
                    Console.Write("请输入第{0}个人的成绩：", i + 1);
                    iScore = Convert.ToInt32(Console.ReadLine());
                    if (iScore < 0 || iScore > 100)
                    {
                        Console.WriteLine("输入的成绩超过了范围，程序退出");
                        bFlag = false;
                        break;
                    }
                    else
                    {
                        iSum += iScore;
                    }
                }
                catch
                {
                    Console.WriteLine("输入的成绩有误，程序强制退出");
                    break;
                }
                i++;
            }
            if (bFlag)
            {
                Console.WriteLine("三个人的平均成绩是：" + iSum / 3);
            }
        }
        #endregion

        #region CP05_24：用while语句和continue计算题
        /*
         *  例程编号：CP05_24
         *  摘要：
         *      用while语句和continue计算题
         *  说明：
         *      1）计算1-100中，除了能被7整除的数以外的其他数之和
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
        /// 用while语句和continue计算题
        /// </summary>
        public static void CP05_24()
        {
            int iSum = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 7 == 0)
                {
                    i++;
                    continue;
                }
                iSum += i;
                i++;
            }
            Console.WriteLine("1-100中，除了能被7整除的以外，其他数之和是：" + iSum);
        }
        #endregion


    }
}