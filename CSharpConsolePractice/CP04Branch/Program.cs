#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP04Branch
 * 项目描述 ：选择分支的练习文档
 * 类 名 称 ：Program
 * 类 描 述 ：选择分支的练习文档
 * 命名空间 ：CP04Branch
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-08 19:42:00
 * 更新时间 ：2020-03-08 19:42:00
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

/*
 *  选择分支结构：
 *      if...
 *      if...else...
 *      if...else if...else if...else
 *      switch...
 */

using System;
using CP00Forms;

namespace CP04Branch
{
    class Program
    {
        static void Main(string[] args)
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
            #endregion
            //Forms.Line("CP04_01");
            //Bch01IfStatement.CP04_01();

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
            #endregion
            //Forms.Line("CP04_02");
            //Bch01IfStatement.CP04_02();

            #region CP04_03：switch语句的2个练习
            /*
             *  例程编号：CP04_03
             *  摘要：
             *      switch语句的2个练习
             *  说明：
             *      1）利用switch语句，键盘输入1~7，输出星期几
             *  步骤：
             *      1）键盘输入1~7，输出星期几
             *      2）键盘输入月份，输出季节
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  int         iDay
             *                  int         iMonth
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP04_03");
            //Bch01IfStatement.CP04_03();
        }
    }
}
