#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP03Operator
 * 项目描述 ：
 * 类 名 称 ：Op02Assignment
 * 类 描 述 ：赋值运算符
 * 命名空间 ：CP03Operator
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-08 14:40:46
 * 更新时间 ：2020-03-08 14:40:46
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP03Operator
{
    public class Op02Assignment
    {
        #region CP03_09：6种赋值运算符（=、+=、-=、*=、/=、%=）
        /*
         *  例程编号：CP03_09
         *  摘要：
         *      6种赋值运算符（=、+=、-=、*=、/=、%=）
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar1
         *                  int         iVar2
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 6种赋值运算符（=、+=、-=、*=、/=、%=）
        /// </summary>
        public static void CP03_09()
        {
            int iVar1, iVar2;
            //=
            iVar1 = 1;
            Console.WriteLine("iVar1 = {0}", iVar1);
            //+=
            iVar1 = 1;iVar2 = 2;
            Console.WriteLine("iVar1 += iVar2 = {0}", iVar1 += iVar2);
            //-=
            iVar1 = 1; iVar2 = 2;
            Console.WriteLine("iVar1 -= iVar2 = {0}", iVar1 -= iVar2);
            //*=
            iVar1 = 1; iVar2 = 2;
            Console.WriteLine("iVar1 *= iVar2 = {0}", iVar1 *= iVar2);
            ///=
            iVar1 = 1; iVar2 = 2;
            Console.WriteLine("iVar1 /= iVar2 = {0}", iVar1 /= iVar2);
            //%=
            iVar1 = 1; iVar2 = 2;
            Console.WriteLine("iVar1 %= iVar2 = {0}", iVar1 %= iVar2);
        }
        #endregion
    }
}