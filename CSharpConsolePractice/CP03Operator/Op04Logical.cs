#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP03Operator
 * 项目描述 ：
 * 类 名 称 ：Op04Logical
 * 类 描 述 ：逻辑运算符
 * 命名空间 ：CP03Operator
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-08 16:06:10
 * 更新时间 ：2020-03-08 16:06:10
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

namespace CP03Operator
{
    public class Op04Logical
    {
        #region CP03_11：6种逻辑运算符（&、&&、|、||、！、^）
        /*
         *  例程编号：CP03_11
         *  摘要：
         *      6种逻辑运算符（&、&&、|、||、！、^）
         *  说明：
         *      1）&和|：每个表达式都会执行
         *         &&和||：短路效应，只要其中一个满足整个逻辑表达式的条件，往后就不会执行
         *         &&：若运算符左侧操作数（表达式）为false，则整个表达式的结果为false，不会执行右侧表达式
         *         ||：若运算符左侧操作数（表达式）为true，则整个表达式的结果为true，不会执行右侧表达式
         *      2）观察每个逻辑表达式的运算结果
         *  步骤：
         *      1）
         *  变量：
         *      修饰符          变量类型         变量名         备注
         *                      int             iVar1
         *                      int             iVar2
         *                      int             iVar3
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        public static void CP03_12()
        {
            int iVar1 = 1, iVar2 = 2, iVar3 = 3;
            Console.WriteLine("iVar1 = {0}, iVar2 = {1}, iVar3 = {2}", iVar1, iVar2, iVar3);
            Forms.Cut();
            //  &
            Console.WriteLine("(iVar1 > iVar2) & (iVar1 > iVar3) : {0}", (iVar1 > iVar2) & (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) & (iVar1 > iVar3) : {0}", (iVar1 > iVar2) & (iVar1 < iVar3));
            Console.WriteLine("(iVar1 > iVar2) & (iVar1 > iVar3) : {0}", (iVar1 < iVar2) & (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) & (iVar1 > iVar3) : {0}", (iVar1 < iVar2) & (iVar1 < iVar3));
            Forms.Cut();
            //  &&
            Console.WriteLine("(iVar1 > iVar2) && (iVar1 > iVar3) : {0}", (iVar1 > iVar2) && (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) && (iVar1 > iVar3) : {0}", (iVar1 > iVar2) && (iVar1 < iVar3));
            Console.WriteLine("(iVar1 > iVar2) && (iVar1 > iVar3) : {0}", (iVar1 < iVar2) && (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) && (iVar1 > iVar3) : {0}", (iVar1 < iVar2) && (iVar1 < iVar3));
            Forms.Cut();
            //  |
            Console.WriteLine("(iVar1 > iVar2) | (iVar1 > iVar3) : {0}", (iVar1 > iVar2) | (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) | (iVar1 > iVar3) : {0}", (iVar1 > iVar2) | (iVar1 < iVar3));
            Console.WriteLine("(iVar1 > iVar2) | (iVar1 > iVar3) : {0}", (iVar1 < iVar2) | (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) | (iVar1 > iVar3) : {0}", (iVar1 < iVar2) | (iVar1 < iVar3));
            Forms.Cut();
            //  ||
            Console.WriteLine("(iVar1 > iVar2) || (iVar1 > iVar3) : {0}", (iVar1 > iVar2) || (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) || (iVar1 > iVar3) : {0}", (iVar1 > iVar2) || (iVar1 < iVar3));
            Console.WriteLine("(iVar1 > iVar2) || (iVar1 > iVar3) : {0}", (iVar1 < iVar2) || (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) || (iVar1 > iVar3) : {0}", (iVar1 < iVar2) || (iVar1 < iVar3));
            Forms.Cut();
            //  ！
            Console.WriteLine("!(iVar1 > iVar2) : {0}", !(iVar1 > iVar2));
            Console.WriteLine("!(iVar1 > iVar2) : {0}", !(iVar1 > iVar2));
            Console.WriteLine("!(iVar1 > iVar2) : {0}", !(iVar1 < iVar2));
            Console.WriteLine("!(iVar1 > iVar2) : {0}", !(iVar1 < iVar2));
            Forms.Cut();
            //  ^
            Console.WriteLine("(iVar1 > iVar2) ^ (iVar1 > iVar3) : {0}", (iVar1 > iVar2) ^ (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) ^ (iVar1 > iVar3) : {0}", (iVar1 > iVar2) ^ (iVar1 < iVar3));
            Console.WriteLine("(iVar1 > iVar2) ^ (iVar1 > iVar3) : {0}", (iVar1 < iVar2) ^ (iVar1 > iVar3));
            Console.WriteLine("(iVar1 > iVar2) ^ (iVar1 > iVar3) : {0}", (iVar1 < iVar2) ^ (iVar1 < iVar3));
        }
        #endregion
    }
}