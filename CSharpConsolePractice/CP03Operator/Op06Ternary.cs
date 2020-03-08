#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP03Operator
 * 项目描述 ：
 * 类 名 称 ：Op06Ternary
 * 类 描 述 ：三目运算符
 * 命名空间 ：CP03Operator
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-08 17:50:19
 * 更新时间 ：2020-03-08 17:50:19
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
    public class Op06Ternary
    {
        #region CP03_13：三目运算符( ? : )
        /*
         *  例程编号：CP03_13
         *  摘要：
         *      三目运算符( ? : )
         *  说明：
         *      1）(条件是否满足？满足了就执行表达式1：不满足就执行表达式2）
         *  步骤：
         *      1）求两个整数最大值
         *      2）求三个整数最大值，方法一（用中间变量）
         *      3）求三个整数最大值，方法二
         *      4）求三个整数最大值，方法三
         *      5）做条件判断，用于后续分支执行的判定条件
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar1
         *                  int         iVar2
         *                  int         iVar3
         *  方法：
         *      修饰符      返回值类型    方法名          参数类型1  参数类型2  参数类型3   备注
         *                  int          TeryTwoInt      int        int       int
         *                  int          TeryThreeIntM1  int        int       int
         *                  int          TeryThreeIntM2  int        int       int
         *                  int          TeryThreeIntM3  int        int       int
         *                  bool         TeryFlag        int        int
         */
        /// <summary>
        /// 三目运算符( ? : )
        /// </summary>
        public static void CP03_13()
        {
            int iVar1, iVar2, iVar3;
            Console.WriteLine("请输入三个整形数据：");
            Console.Write("整形数据1 ：");
            iVar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("整形数据2 ：");
            iVar2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("整形数据3 ：");
            iVar3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("数据1和数据2的最大值是：" + TeryTwoInt(iVar1, iVar2));
            Console.WriteLine("数据1、数据2和数据3，运用方法1，最大值是：" + TeryThreeIntM1(iVar1, iVar2, iVar3));
            Console.WriteLine("数据1、数据2和数据3，运用方法2，最大值是：" + TeryThreeIntM2(iVar1, iVar2, iVar3));
            Console.WriteLine("数据1、数据2和数据3，运用方法3，最大值是：" + TeryThreeIntM3(iVar1, iVar2, iVar3));
            Console.WriteLine("Flag条件判断的结果是：" + TeryFlag(iVar1, iVar2));
        }

        /// <summary>
        /// 求两个整数最大值
        /// </summary>
        /// <param name="num1">整形变量1</param>
        /// <param name="num2">整形变量2</param>
        /// <returns>返回两个整型变量的最大值</returns>
        public static int TeryTwoInt(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        /// <summary>
        /// 求三个整数最大值，方法一
        /// </summary>
        /// <param name="num1">整形变量1</param>
        /// <param name="num2">整形变量2</param>
        /// <param name="num3">整形变量3</param>
        /// <returns>返回三个整形变量的最大值</returns>
        public static int TeryThreeIntM1(int num1, int num2, int num3)
        {
            int iMax = num1 > num2 ? num1 : num2;
            iMax = iMax > num3 ? iMax : num3;
            return iMax;
        }

        /// <summary>
        /// 求三个整数最大值，方法二
        /// </summary>
        /// <param name="num1">整形变量1</param>
        /// <param name="num2">整形变量2</param>
        /// <param name="num3">整型变量3</param>
        /// <returns>返回三个整形变量的最大值</returns>
        public static int TeryThreeIntM2(int num1, int num2, int num3)
        {
            return (num1 > num2 ? num1 : num2) > num3 ? (num1 > num2 ? num1 : num2) : num3;
        }

        /// <summary>
        /// 求三个整数最大值，方法三
        /// </summary>
        /// <param name="num1">整形变量1</param>
        /// <param name="num2">整形变量2</param>
        /// <param name="num3">整型变量3</param>
        /// <returns>返回三个整形变量的最大值</returns>
        public static int TeryThreeIntM3(int num1, int num2, int num3)
        {
            return (num1 > num2 ? (num1 > num3 ? num1 : num3) : num2 > num3 ? num2 : num3);
        }

        /// <summary>
        /// 做条件判断，用于后续分支执行的判定条件
        /// </summary>
        /// <param name="num1">整形变量1</param>
        /// <param name="num2">整形变量2</param>
        /// <returns>真价值，用于后续分支判断的依据</returns>
        public static bool TeryFlag(int num1,int num2)
        {
            bool bFlag;
            bFlag = (num1 > num2 ? true : false);
            return bFlag;
        }
        #endregion
    }
}