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
* 更新时间 ：2020-02-05 10:52:00
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
        /*
         *  例程编号：CS003（设计用例）
         *  说明：
         *      输出常量（字符串、字符、整数、小数、金钱、布尔、二进制、八进制、十六进制)
         */
        public const string v003Str = "this is a string";
        public const char v003Ch = 'a';
        public const byte v003BytNum = 1;//无法大于255
        public const short v003ShoNum = 256;
        public const int v003IntNum = 123456789;
        public const long v003LonNum = 12345678910;//在Java中要在末尾加L，C#不需要？
        public const float v003FloNum = 12.3456789F;//float浮点数需要在末尾加F
        public const double v003DouNum= 12.3456789;
        public const decimal v003DecNum = 12.3456789M;//金钱类型需要在末尾加M
        public const bool v003Flag = true;
        public const int v003IntNum2 = 0b101;//二进制，以0b开头，十进制的5
        public const int v003IntNum3 = 0123;//八进制，以0开头，十进制的83????????????????????????
        public const int v003IntNum4 = 0x123;//十六进制，以0x开头，十进制的291

        /// <summary>
        /// 在控制台上打印各种类型的常量
        /// </summary>
        public static void ShowConstants()
        {
            Console.WriteLine(v003Str);
            Console.WriteLine(v003Ch);
            Console.WriteLine(v003BytNum);
            Console.WriteLine(v003ShoNum);
            Console.WriteLine(v003IntNum);
            Console.WriteLine(v003LonNum);
            Console.WriteLine(v003FloNum);
            Console.WriteLine(v003DouNum);
            Console.WriteLine(v003DecNum);
            Console.WriteLine(v003Flag);
            Console.WriteLine(v003IntNum2);
            Console.WriteLine(v003IntNum3);
            Console.WriteLine(v003IntNum4);
        }
    }
}
