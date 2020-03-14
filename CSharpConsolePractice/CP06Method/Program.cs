#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP06Method
 * 项目描述 ：方法的使用归纳
 * 类 名 称 ：Program
 * 类 描 述 ：方法的使用归纳
 * 命名空间 ：CP06Method
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-14 17:07:00
 * 更新时间 ：2020-03-14 17:07:00
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

/*
 *  方法的使用：
 *      
 */

using System;
using CP00Forms;

namespace CP06Method
{
    class Program
    {
        static void Main(string[] args)
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
            #endregion
            Forms.Line("CP06_01");
            Mt01Method.CP06_01();
        }
    }
}
