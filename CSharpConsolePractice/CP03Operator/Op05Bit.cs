#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP03Operator
 * 项目描述 ：
 * 类 名 称 ：Op05Bit
 * 类 描 述 ：位运算符
 * 命名空间 ：CP03Operator
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-08 16:50:58
 * 更新时间 ：2020-03-08 16:50:58
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
    public class Op05Bit
    {
        #region CP03_12：4种位运算符（&、|、^、!）
        /*
         *  例程编号：CP03_12
         *  摘要：
         *      4种位运算符（&、|、^、~）
         *  说明：
         *      1）意义
         *          &   两个二进制按位做与运算
         *          |   两个二进制按位做或运算
         *          ^   两个二进制按位做异或运算
         *          ~   一个二进制按位取反
         *      2）一个变量对另一个变量异或两次，结果不变
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
        /// 4种位运算符（&、|、^、~）
        /// </summary>
        public static void CP03_12()
        {
            int iVar1 = 3, iVar2 = 4;
            Console.WriteLine("iVar1 = {0}, Binary = {1}", iVar1, Convert.ToString(iVar1, 2));
            Console.WriteLine("iVar2 = {0}, Binary = {1}", iVar2, Convert.ToString(iVar2, 2));
            Console.WriteLine("iVar1 & iVar2 = {0}", iVar1 & iVar2);
            Console.WriteLine("iVar1 | iVar2 = {0}", iVar1 | iVar2);
            Console.WriteLine("iVar1 ^ iVar2 = {0}", iVar1 ^ iVar2);
            Console.WriteLine("~iVar1 = {0}", ~iVar1);
            //一个变量对另一个变量异或两次，结果不变
            Console.WriteLine("iVar1 = {0}, iVar2 = {1}", iVar1, iVar2);
            Console.WriteLine("iVar1 ^ iVar2 ^ iVar2 = " + (iVar1 ^ iVar2 ^ iVar2));
            Console.WriteLine("iVar2 ^ iVar1 ^ iVar1 = " + (iVar2 ^ iVar1 ^ iVar1));
        }
        #endregion
    }
}