#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP06Method
 * 项目描述 ：
 * 类 名 称 ：Mt01Method
 * 类 描 述 ：方法的基本用法
 * 命名空间 ：CP06Method
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-14 16:39:25
 * 更新时间 ：2020-03-14 16:39:25
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP06Method
{
    public class Mt01Method
    {
        #region CP06_01：方法的形参和实参
        /*
         *  例程编号：CP06_01
         *  摘要：
         *      方法的形参和实参
         *  说明：
         *      1）形参无法改变实参的例程
         *      2）形参能改变实参的例程
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar
         *                  int[]       iArray
         *  方法：
         *      修饰符         返回值类型    方法名          参数类型    备注
         *                      void        Change_1        int
         *                      int         Change_2        int
         *                      void        ChangeArray     int[]
         */
        /// <summary>
        /// 方法的形参和实参
        /// </summary>
        public static void CP06_01()
        {
            //形参无法改变实参
            int iVar = 1;
            Console.WriteLine("用Change_1()方法改变iVar1的值");
            Console.WriteLine("现在iVar的值是：" + iVar);
            Change_1(iVar);
            Console.WriteLine("运行Change_1()方法后，iVar的值是：" + iVar);
            iVar = Change_2(iVar);
            Console.WriteLine("运行Change_2()方法后，iVar的值是：" + iVar);

            //形参改变实参
            int[] iArray = { 1 };
            Console.WriteLine("用ChangeArray()方法改变iArray的元素值");
            Console.WriteLine("现在iArray[0]的值是：" + iArray[0]);
            ChangeArray(iArray);
            Console.WriteLine("运行ChangeArray()方法后，iArray[0]的值是：" + iArray[0]);

        }
        /// <summary>
        /// 形参无法改变实参，方法1
        /// </summary>
        /// <param name="iVar1">需要改变的值</param>
        public static void Change_1(int iVar)
        {
            iVar = 2;
        }

        /// <summary>
        /// 形参无法改变实参，方法2,必须返回数据
        /// </summary>
        /// <param name="iVar">需要改变的值</param>
        /// <returns>返回改变后的值</returns>
        public static int Change_2(int iVar)
        {
            return iVar = 2;
        }

        /// <summary>
        /// 形参能改变实参，因为，实参是个引用类型数据
        /// </summary>
        /// <param name="iArray"></param>
        public static void ChangeArray(int[] iArray)
        {
            iArray[0] = 2;
        }
        #endregion
    }
}