#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP06Method
 * 项目描述 ：
 * 类 名 称 ：Mt03Ref
 * 类 描 述 ：ref参数的使用
 * 命名空间 ：CP06Method
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-15 19:20:06
 * 更新时间 ：2020-03-15 19:20:06
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
    public class Mt03Ref
    {
        #region CP06_06：ref参数的例程
        /*
         *  例程编号：CP06_06
         *  摘要：
         *      ref参数的例程
         *  说明：
         *      1）ref参数作为形参传入，能改变实参的值
         *      2）声明方法，如：out int i;
         *      3）使用的时候也必须又out，如：test(num,out ret);
         *      4）在方法体内，必须先给各个out参数进行赋值，不能范围未经赋值的out参数
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar
         *  方法：
         *      修饰符     返回值类型    方法名            参数类型    备注
         *                  void        ChangeVar       ref int
         */
        /// <summary>
        /// ref参数的例程
        /// </summary>
        public static void CP06_06()
        {
            int iVar = 1;
            Console.WriteLine("开始的时候iVar = " + iVar);
            Console.WriteLine("执行ChangeVar()方法。");
            ChangeVar(ref iVar);
            if (iVar == 2)
            {
                Console.WriteLine("iVar被重新赋值，现在的iVar = " + iVar);
            }
            else
            {
                Console.WriteLine("重新赋值失败，iVar没有被改变。");
            }
        }
        /// <summary>
        /// 使用ref参数改变实参的值
        /// </summary>
        /// <param name="iVar">改变了实参的值</param>
        public static void ChangeVar(ref int iVar)
        {
            iVar = 2;
        }
        #endregion

        #region CP06_07：ref参数交换2个整形变量的值
        /*
         *  例程编号：CP06_07
         *  摘要：
         *      ref参数交换2个整形变量的值
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar_1
         *                  int         iVar_2
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         *                  void        ChangeVar       ref int, ref int
         */
        public static void CP06_07()
        {
            int iVar_1 = 1;
            int iVar_2 = 2;
            Console.WriteLine("开始的时候，iVar_1 = {0}，iVar_2= {1}", iVar_1, iVar_2);
            Console.WriteLine("执行ChangeVar()方法...");
            ChangeVar(ref iVar_1, ref iVar_2);
            if (iVar_1 == 1 && iVar_2 == 2)
            {
                Console.WriteLine("执行完毕后，iVar_1 和 iVar_2 的数值并没有发生变化。");
            }
            else
            {
                Console.WriteLine("交换完毕，现在iVar_1 = {0}，ivar_2 = {1}", iVar_1, iVar_2);
            }
        }

        /// <summary>
        /// 利用ref交换两个整形变量实参的值
        /// </summary>
        /// <param name="iVar_1">整型变量1</param>
        /// <param name="iVar_2">整型变量2</param>
        public static void ChangeVar(ref int iVar_1, ref int iVar_2)
        {
            int iTemp = iVar_1;
            iVar_1 = iVar_2;
            iVar_2 = iTemp;
        }
        #endregion


    }
}