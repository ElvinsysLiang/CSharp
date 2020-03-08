#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP03Operator
 * 项目描述 ：
 * 类 名 称 ：Op03Comparison
 * 类 描 述 ：比较运算符
 * 命名空间 ：CP03Operator
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-08 15:19:50
 * 更新时间 ：2020-03-08 15:19:50
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
    public class Op03Comparison
    {
        #region CP03_10：6种比较运算符（==、！=、>、>=、<、<=）
        /*
         *  例程编号：CP03_10
         *  摘要：
         *      6种比较运算符（==、！=、>、>=、<、<=）
         *  说明：
         *      1）返回的是一个bool值（真 或者 假）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar1
         *                  int         iVar2
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
         public static void CP03_10()
        {
            int iVar1 = 3, iVar2 = 4;
            //  ==
            Console.WriteLine("iVar1 == iVar2 : {0}", iVar1 == iVar2);
            //  !=
            Console.WriteLine("iVar1 != iVar2 : {0}", iVar1 != iVar2);
            //  >
            Console.WriteLine("iVar1 > iVar2 : {0}", iVar1 > iVar2);
            //  >=
            Console.WriteLine("iVar1 >= iVar2 : {0}", iVar1 >= iVar2);
            //  <
            Console.WriteLine("iVar1 < iVar2 : {0}", iVar1 < iVar2);
            //  <=
            Console.WriteLine("iVar1 <= iVar2 : {0}", iVar1 <= iVar2);
        }
        #endregion
    }
}