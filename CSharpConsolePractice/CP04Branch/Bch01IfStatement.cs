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
using CP00Forms;

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

        #region CP04_02：if语句的6个练习
        /*
         *  例程编号：CP04_02
         *  摘要：
         *      if语句的6个练习
         *  说明：
         *      1）
         *  步骤：
         *      1）比较两个数是否相等（格式二）
         *      2）获取两个数的最大值（格式二）
         *      3）获取三个数的最大值（嵌套，格式三，三目运算符）
         *      4）根据成绩输出对应的等级（格式三）
         *      5）根据月份输出对应的季节（格式三）
         *      6）根据x计算对应y的值（格式三）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar1
         *                  int         iVar2
         *                  int         iVar3
         *                  int         iMax
         *                  int         iScore
         *                  int         iMonth
         *                  int         iX
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */

        /// <summary>
        /// if语句的6个练习
        /// </summary>
        public static void CP04_02()
        {
            int iMax, iVar1 = 3, iVar2 = 4, iVar3 = 5;
            int iScore, iMonth, iX;
            Console.WriteLine("iVar1 = {0}, iVar2 = {1}, iVar3 = {2}.", iVar1, iVar2, iVar3);
            Forms.Cut();

            //1）比较两个数是否相等（格式二）
            if (iVar1 == iVar2)
            {
                Console.WriteLine("比较两个数是否相等，结果是：相等的");
            }
            else
            {
                Console.WriteLine("比较两个数是否相等，结果是：不相等的");
            }
            Forms.Cut();

            //2）获取两个数的最大值（格式二）
            if (iVar1 > iVar2)
            {
                Console.WriteLine("获取两个数的最大值，结果是：iVar1大于iVar2，因此，最大值是：" + iVar1);
            }
            else
            {
                Console.WriteLine("获取两个数的最大值，结果是：iVar2大于或等于iVar1，因此，最大值是：" + iVar2);
            }
            Forms.Cut();

            //3）获取三个数的最大值（嵌套，格式三，三目运算符）
            Console.WriteLine("先用嵌套来实现：");
            if (iVar1 > iVar2)
            {
                if (iVar1 > iVar3)
                {
                    Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iVar1);
                }
                else
                {
                    Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iVar3);
                }
            }
            else
            {
                if (iVar2 > iVar3)
                {
                    Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iVar2);
                }
                else
                {
                    Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iVar3);
                }
            }

            Console.WriteLine("然后用格式三实现：");
            if (iVar1 > iVar2 && iVar1 > iVar3)
            {
                Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iVar1);
            }
            else if (iVar2 > iVar1 && iVar2 > iVar3)
            {
                Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iVar2);
            }
            else
            {
                Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iVar3);
            }

            Console.WriteLine("最后用三目运算符来实现：");
            iMax = iVar1 > iVar2 ? (iVar1 > iVar3 ? iVar1 : iVar3) : (iVar2 > iVar3 ? iVar2 : iVar3);
            Console.WriteLine("iVar1 iVar2 iVar3 中的最大值是：" + iMax);
            Forms.Cut();

            //4）根据成绩输出对应的等级（格式三）
            Console.Write("请输入一个整数成绩，判定优良中差：");
            iScore = Convert.ToInt32(Console.ReadLine());
            if (iScore > 100 || iScore < 0)
            {
                Console.WriteLine("您输入的成绩有误。");
            }
            else if (iScore < 60)
            {
                Console.WriteLine("不及格了，丢去参加补习班");
            }
            else if (iScore >= 60 && iScore < 70)
            {
                Console.WriteLine("成绩中等，给一个小红花吧");
            }
            else if (iScore >= 70 && iScore < 90)
            {
                Console.WriteLine("成绩良好，给两个小红花");
            }
            else
            {
                Console.WriteLine("成绩优秀，给三个小红花");
            }
            Forms.Cut();

            //5）根据月份输出对应的季节（格式三）
            Console.Write("请输入一个月份来判断季节：");
            iMonth = Convert.ToInt32(Console.ReadLine());
            if (iMonth <= 0 || iMonth > 12)
            {
                Console.WriteLine("输入的月份有误");
            }
            else if (iMonth == 12 || iMonth == 1 || iMonth == 2)
            {
                Console.WriteLine("{0}月是冬季", iMonth);
            }
            else if (iMonth == 3 || iMonth == 4 || iMonth == 5)
            {
                Console.WriteLine("{0}月是春季", iMonth);
            }
            else if (iMonth == 6 || iMonth == 7 || iMonth == 8)
            {
                Console.WriteLine("{0}月是夏季", iMonth);
            }
            else
            {
                Console.WriteLine("{0}月是秋季", iMonth);
            }
            Forms.Cut();

            //6）根据x计算对应y的值（格式三）
            Console.Write("请输入x值，计算出y值:");
            iX = Convert.ToInt32(Console.ReadLine());
            if (iX >= 3)
            {
                Console.WriteLine("x = {0}, y = {1}", iX, 2 * iX + 1);
            }
            else if (iX >= -1 && iX < 3)
            {
                Console.WriteLine("x = {0}, y = {1}", iX, 2 * iX);
            }
            else
            {
                Console.WriteLine("x = {0}, y = {1}", iX, 2 * iX - 1);
            }
        }
        #endregion
    }
}