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
            //Forms.Line("CP06_01");
            //Mt01Method.CP06_01();

            #region CP06_02：方法的例程
            /*
             *  例程编号：CP06_02
             *  摘要：
             *      方法的例程
             *  说明：
             *      1）用户输入整形数据，如果不是整数，提示重新输入
             *      2）利用的语句：while，try...catch...
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  int         iVar
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP06_02");
            //Mt01Method.CP06_02();

            #region CP06_03：out参数的例程
            /*
             *  例程编号：CP06_03
             *  摘要：
             *      out参数的例程
             *  说明：
             *      1）声明方法，如：out int i;
             *      2）使用的时候也必须又out，如：test(num,out ret);
             *      3）在方法体内，必须先给各个out参数进行赋值，不能范围未经赋值的out参数
             *      4）如果需要返回多个索引值（结果）呢？
             *  步骤：
             *      1）在整形数组中根据元素值找对应的索引值
             *      2）是否找到，用return返回
             *      3）找到的结果用out参数返回。
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  int[]       iArray      要处理的数组
             *                  int         iData       索引值对应的数据
             *                  int         iIndex      接收索引值的结果
             *                  bool        bFlag       是否找到索引值
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP06_03");
            //Mt02Out.CP06_03();

            #region CP06_04：out参数求数组各类结果
            /*
             *  例程编号：CP06_04
             *  摘要：
             *      out参数求数组各类结果
             *  说明：
             *      1）数组的最大值
             *      2）最大值的索引
             *      3）数组的最小值
             *      4）最小值的索引
             *      5）数组的和
             *      6）数组的平均值
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  int[]       iArray      需要处理的数组
             *                  bool        iFlag       是否成功求出结果
             *                  int         iMax        最大值
             *                  int         iMaxIndex   最大值的索引值
             *                  int         iMin        最小值
             *                  int         iMinIndex   最小值的索引值
             *                  int         iSum        数组元素值的总和
             *                  int         iAvg        数组元素值的平均值
             *  方法：
             *      修饰符     返回值类型    方法名            参数类型    备注
             *                  bool        GetMaxMinSumAvg     int[]   int int int int int int
             */
            #endregion
            //Forms.Line("CP06_04");
            //Mt02Out.CP06_04();

            #region CP06_05：方法实现户名密码登录程序
            /*
             *  例程编号：CP06_05
             *  摘要：
             *      方法实现用户名密码登录程序
             *  说明：
             *      1）使用out参数输出错误原因
             *      2）用while语句，直到用户名和密码都输入正确
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  string      strUserName     用户名
             *                  string      strPwd          密码
             *                  string      strMsg          错误信息
             *                  bool        bFlag           用户名密码正确性检验结果
             *  方法：
             *      修饰符     返回值类型    方法名            参数类型    备注
             *                  bool        CheckStatus     string  string  string
             */
            #endregion
            //Forms.Line("CP06_05");
            //Mt02Out.CP06_05();
        }
    }
}
