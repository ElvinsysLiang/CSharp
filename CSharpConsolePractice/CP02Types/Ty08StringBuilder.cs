#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty08StringBuilder
 * 类 描 述 ：StringBuilder的用法
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-22 18:54:40
 * 更新时间 ：2020-03-22 18:54:40
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace CP02Types
{
    public class Ty08StringBuilder
    {
        #region CP02_23：StringBuilder的例程
        /*
         *  例程编号：CP02_23
         *  摘要：
         *      StringBuilder的例程
         *  说明：
         *      1）字符串和可变字符串的区别
         *          字符串：长度固定,每次修改进行赋值，实质上是在堆中创建新的字符串
         *          可变字符串：长度可变，可进行追加/移除/替换/插入等操作
         *      2）创建集合  StringBuilder strBuder = new StringBuilder();
         *          需要在文件头加入using System.Text;
         *      3）追加字符串 StringBuilder.Append(Int / Char / String);
         *      4）追加数组 StringBuilder.AppendJoin(Char,StrBuilder);
         *      5）删除下标范围字符 StringBuilder.Remove(Int,Int);
         *      6）删除指定下标数据 StringBuilder.Insert(Int,Char);
         *      7）替换指定内容字符 StringBuilder.Replace(Char,Char);
         *      8）可变字符串大小 StringBuilder.Capacity;
         *          其实容量，和集合一样，容量随着字符串的变化而双倍增加
         *  步骤：
         *      1）
         */
        public static void CP02_23()
        {
            int[] iArr = new int[] { 1, 2, 3 };
            //2）创建集合  StringBuilder strBuder = new StringBuilder();
            Console.WriteLine("创建可变字符串...");
            StringBuilder strBuder = new StringBuilder();

            CP00Forms.Forms.Cut();

            //3）追加字符串 StringBuilder.Append(Int / Char / String);
            Console.WriteLine("添加数据...");
            strBuder.Append("12345");
            PrintStrBuder(strBuder);

            CP00Forms.Forms.Cut();

            //4）追加数组 StringBuilder.AppendJoin(Char,StrBuilder);
            Console.WriteLine("数组元素以'|'分隔，并追加到可变字符串中...");
            strBuder.AppendJoin('|', iArr);
            PrintStrBuder(strBuder);

            CP00Forms.Forms.Cut();

            //5）删除下标范围字符 StringBuilder.Remove(Int,Int);
            Console.WriteLine("删除下标为1的连续2个字符...");
            strBuder.Remove(1, 2);
            PrintStrBuder(strBuder);

            CP00Forms.Forms.Cut();

            //6）删除指定下标数据 StringBuilder.Insert(Int,Char);
            Console.WriteLine("在下标为1的位置，插入2");
            strBuder.Insert(1, 2);
            PrintStrBuder(strBuder);

            CP00Forms.Forms.Cut();

            //7）替换指定内容字符 StringBuilder.Replace(Char,Char);
            Console.WriteLine("把字符‘4’替换为‘3’...");
            strBuder.Replace('4', '3');
            PrintStrBuder(strBuder);

            CP00Forms.Forms.Cut();

            //8）可变字符串大小 StringBuilder.Capacity;
            //  其实容量，和集合一样，容量随着字符串的变化而双倍增加
            Console.WriteLine("可变字符串的大小...");
            Console.WriteLine("大小是：" + strBuder.Capacity);
        }
        public class Person23
        {
            public void SayHi()
            {
                Console.WriteLine("Hi.");
            }
        }
        public static void PrintStrBuder(StringBuilder strBuder)
        {
            Console.WriteLine("打印可变字符串的值：" + strBuder);
        }
        #endregion
    }
}