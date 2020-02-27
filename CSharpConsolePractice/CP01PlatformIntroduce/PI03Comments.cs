#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP01PlatformIntroduce
* 项目描述 ：
* 类 名 称 ：PI03Comments
* 类 描 述 ：文档注释的例程
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP01PlatformIntroduce
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-05 10:03:04
* 更新时间 ：2020-02-27 09:28:00
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace CP01PlatformIntroduce
{
    class PI03Comments
    {
        /*
         *  例程编号：CS003
         *  摘要：
         *      注释的用法，命名方式，两数相加
         *  要点：
         *      1）注释的用法
         *          单行注释：//
         *          多行注释：/米...米/
         *          文档注释：///
         *      2）命名方式
         *          Pascal：
         *              类名：Person
         *              成员名：Number
         *              方法名：Add（）
         *          Camel：
         *              局部变量：userName
         *      3）定义变量和创建方法的方法
         *      4）键盘输入数据的方法
         *          通过Console.ReadLine()方法捕获用户从键盘输入的数据，但
         *          捕获的是字符串数据，需要通过Convert.ToInt32()转换格式。
         *  步骤：
         *      1）定义两个方法
         *          方法一：用户输入两个整形数据，计算两个整形数据相加的结果，返回一个整形数据
         *          方法二：在控制台上输出计算的结果
         *  变量：
         *      修饰符     变量类型     变量名     备注
         *                  int         var1
         *                  int         var2
         *                  int         result
         *      
         *  方法：
         *      修饰符         返回值类型    方法名     参数1类型  参数2类型   备注
         *      public static   int         MyAdd         int      int
         *      public static   void        ShowResult  int
         */
        public static void CS003()
        {
            int var1, var2, result;
            Console.WriteLine("Please input two integerNum:");
            Console.Write("Number1 is:");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2 is:");
            var2 = Convert.ToInt32(Console.ReadLine());
            result = MyAdd(var1, var2);
            ShowResult(result);
        }
        /// <summary>
        /// 用户输入两个整形数据，计算两个整形数据相加的结果，返回一个整形数据
        /// </summary>
        /// <param name="a">第一个整形参数</param>
        /// <param name="b">第二个整形参数</param>
        /// <returns>返回整形数据</returns>
        public static int MyAdd(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 在控制台上输出计算的结果
        /// </summary>
        /// <param name="c">需要打印的整形变量参数</param>
        public static void ShowResult(int c)
        {
            Console.WriteLine("Number1 + Number = "+c);
        }
    }
}
