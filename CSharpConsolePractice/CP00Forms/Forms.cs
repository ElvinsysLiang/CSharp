#region << 版 本 注 释 >>
 /*----------------------------------------------------------------
 * 项目名称 ：CP00Forms
 * 项目描述 ：
 * 类 名 称 ：Fr01Forms
 * 类 描 述 ：解决方案的一些文档写作规范
 * 所在的域 ：LAPTOP-O6ENK577
 * 命名空间 ：CP01PlatformIntroduce
 * 机器名称 ：LAPTOP-O6ENK577 
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-02-03 14:14:05
 * 更新时间 ：2020-02-03 14:14:05
 * 版 本 号 ：v1.0.0.0
 *******************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 *******************************************************************
 //----------------------------------------------------------------*/
#endregion

 /*
  *  解决方案的名称为：CSharpConsolePractice
  *  解决方案以下按照CSharp控制台程序设计的基础知识分为多个项目，目的是用来对基本知识的练习
  *  
  *  草稿：
  *      变量常量
  *      运算符
  *      if...else...switch...
  *      while...do while...，for...foreach...，
  *      方法
  *      面向对象
  * 
  *  解决方案之下，分为若干项目：
  *  CP01-PlatformIntroduce
  *  CP02-Types
  *      string
  *      array
  *  CP03-Operator
  *  CP04-Branch
  *  CP05-Loop
  *  CP06-Method
  *  CP07-ObjectOriented
  *  
  *  项目之下，各类的命名方式
  *  如   PI01Froms
  * 
  */

#region CP01_01：简单的HelloWorld程序
 /*
  *  例程编号：CP01_01
  *  摘要：
  *      简单的HelloWorld程序
  *  说明：
  *      1）
  *  步骤：
  *      1）
  */
#endregion



  /*
 * 变量：
 * 修饰符     变量类型 变量名       备注
* 方法：
 * 修饰符     返回值类型 方法名          参数类型 备注
 * */


/*
 *  用到的变量：
 *  v+例程编号+变量名
 */
/*
 *  用到的方法名：
 *  M+例程编号+方法名
 */

/*
    /// <summary>
    /// 例程分割线
    /// </summary>
    /// <param name="str">例程编号</param>
    public static void Rule(string str)
    {
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("--------------------开始测试  " + str +"--------------------");
        Console.WriteLine("-------------------------------------------------------------------");
    }
 */

/*  ------------------
 *  基础班课程完成状况
 *  -----------------
 *  1   o    11       21
 *  2   o    12       22
 *  3   o    13 
 *  4   o    14 
 *  5   o    15 
 *  6   o    16 
 *  7   o    17
 *  8   o    18
 *  9   o    19
 *  10  o    20
 */

/*
 *  参考材料：
 *     1.课堂例程
 *     2.课件练习
 *     3.JavaSE练习
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CP00Forms
{
    public class Forms
    {
        /// <summary>
        /// 例程分割线
        /// </summary>
        /// <param name="str">例程编号</param>
        public static void Line(string str)
        {
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*-------------------------开始测试  " + str + "-------------------------*");
            Console.WriteLine("*********************************************************************");
        }
        /// <summary>
        /// 例程分割线
        /// </summary>
        /// <param name="str">例程编号</param>
        public static void Cut()
        {
            Console.WriteLine("*********************************************************************");
        }
    }
}
