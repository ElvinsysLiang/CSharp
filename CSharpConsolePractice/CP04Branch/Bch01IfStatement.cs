#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP04Branch
 * 项目描述 ：
 * 类 名 称 ：Bch01IfStatement
 * 类 描 述 ：if语句
 * 命名空间 ：CP04Branch
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-08 20:05:20
 * 更新时间 ：2020-03-08 20:05:20
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP04Branch
{
    public class Bch01IfStatement
    {
        #region CP04_01：if语句的3种结构
        /*
         *  例程编号：CP04_01
         *  摘要：
         *      if语句的3种格式
         *  说明：
         *      1）格式一：用于单个选择判断：if...
         *      2）格式二：用于两个选择判断：if...else...
         *      3）格式三：用于多个选择判断：if...else if...else
         *      4）注意事项：
         *          A：比较表达式无论简单还是复杂，结果都是boolean型；
         *          B：if语句控制的语句体如果是一条语句，可以省略大括号，
         *          如果是多条，则不能省略，建议永远不要省略；
         *          C：有左边大括号，就没有分号，有分号就没有左边大括好；
         *          D：else后面如果没有if嵌套，则没有表达式；
         *          E：三种if格式，只要有一个语句体被执行，其他语句体将不会被执行。
         *  步骤：
         *      1）数据1是否大于数据2（运用if语句格式一）
         *      2）数据1是否大于数据2（运用if语句格式二）
         *      3）数据1是否大于等于或小于数据2（运用if语句格式三）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int          iVar1
         *                  int          iVar2
         *  方法：
         *      修饰符      返回值类型    方法名            参数类型1  参数类型2    备注
         *                  void         IfMethod           int       int
         *                  void         IfElseMethod       int       int
         *                  void         IfElseIfMethod     int       int
         *                  
         */

        /// <summary>
        /// if语句的3种格式
        /// </summary>
        public static void CP04_01()
        {
            int iVar1, iVar2;
            Console.WriteLine("请输入两个整形数据进行比较");
            Console.Write("数据1：");
            iVar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("数据2：");
            iVar2 = Convert.ToInt32(Console.ReadLine());
            IfMethod(iVar1, iVar2);
            IfElseMethod(iVar1, iVar2);
            IfElseIfMethod(iVar1, iVar2);
        }

        /// <summary>
        /// 数据1是否大于数据2（运用if语句格式一）
        /// </summary>
        /// <param name="iVar1">整形数据1</param>
        /// <param name="iVar2">整形数据2</param>
        public static void IfMethod(int iVar1, int iVar2)
        {
            if (iVar1 > iVar2)
            {
                Console.WriteLine("iVar1 > iVar2");
            }
            //如果不满足条件，将不会有任何输出字符
        }

        /// <summary>
        /// 数据1是否大于数据2（运用if语句格式二）
        /// </summary>
        /// <param name="iVar1">整形数据1</param>
        /// <param name="iVar2">整形数据2</param>
        public static void IfElseMethod(int iVar1, int iVar2)
        {
            if (iVar1 > iVar2)
            {
                Console.WriteLine("iVar1 > iVar2");
            }
            else
            {
                Console.WriteLine("iVar1 <= iVar2");
            }
        }

        /// <summary>
        /// 数据1是否大于等于或小于数据2（运用if语句格式三）
        /// </summary>
        /// <param name="iVar1">整形数据1</param>
        /// <param name="iVar2">整形数据2</param>
        public static void IfElseIfMethod(int iVar1, int iVar2)
        {
            if (iVar1 > iVar2)
            {
                Console.WriteLine("iVar1 > iVar2");
            }
            else if (iVar1 == iVar2)
            {
                Console.WriteLine("iVar1 = iVar2");
            }
            else
            {
                Console.WriteLine("iVar1 < iVar2");
            }
        }
        #endregion
    }
}