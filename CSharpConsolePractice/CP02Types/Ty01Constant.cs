#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP02Types
* 项目描述 ：
* 类 名 称 ：Ty01Constant
* 类 描 述 ：常量的用法
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP02Types
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-05 10:52:00
* 更新时间 ：2020-02-27 13:54:35
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion


using System;
using System.Collections.Generic;
using System.Text;

namespace CP02Types
{
    class Ty01Constant
    {
        #region CS004：在控制台上打印各类型的常量
        /*
         *  例程编号：CS004
         *  摘要：
         *      在控制台上打印各种类型的常量
         *  说明：
         *      1）常量一般用const修饰
         *  步骤：
         *      1）输出各类型常量（字符串、字符、整数、小数、金钱、布尔、二进制、八进制、十六进制)
         *  变量：
         *      修饰符      变量类型     变量名      说明
         *      const       string      str     
         *      const       char        ch      
         *      const       byte        bytNum  
         *      const       shotr       shoNum
         *      const       int         intNum
         *      const       long        lonNum
         *      const       float       floNum
         *      const       double      douNum
         *      const       decimal     decNum
         *      const       bool        dlag
         *      const       int         intNum2
         *      const       int         intNum3
         *      const       int         intNum4
         *      
         *  方法：
         *      修饰符         返回值类型    方法名        参数1类型  参数2类型   备注
         *      public static   void       ShowConstants  
         */
        /// <summary>
        /// 在控制台上打印各种类型的常量
        /// </summary>
        public static void CS004()
        {
            const string str = "this is a string";
            const char ch = 'a';
            const byte bytNum = 1;//无法大于255
            const short shoNum = 256;
            const int intNum = 123456789;
            const long lonNum = 12345678910;//在Java中要在末尾加L，C#不需要？
            const float floNum = 12.3456789F;//float浮点数需要在末尾加F
            const double douNum = 12.3456789;
            const decimal decNum = 12.3456789M;//金钱类型需要在末尾加M
            const bool flag = true;
            const int intNum2 = 0b101;//二进制，以0b开头，十进制的5
            const int intNum3 = 0123;//八进制，以0开头，十进制的83????????????????????????
            const int intNum4 = 0x123;//十六进制，以0x开头，十进制的291
            Console.WriteLine(str);
            Console.WriteLine(ch);
            Console.WriteLine(bytNum);
            Console.WriteLine(shoNum);
            Console.WriteLine(intNum);
            Console.WriteLine(lonNum);
            Console.WriteLine(floNum);
            Console.WriteLine(douNum);
            Console.WriteLine(decNum);
            Console.WriteLine(flag);
            Console.WriteLine(intNum2);
            Console.WriteLine(intNum3);
            Console.WriteLine(intNum4);
        }
        #endregion
    }
}
