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
            #endregion
            //Forms.Line("CP06_06");
            //Mt03Ref.CP06_06();

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
            #endregion
            //Forms.Line("CP06_06");
            //Mt03Ref.CP06_07();

            #region CP06_08：psrams参数的例程
            /*
             *  例程编号：CP06_08
             *  摘要：
             *      params参数的例程
             *  说明：
             *      1）params可变参数，其实就是把参数放到数组中进行处理
             *      2）在方法定义的时候，要把params写到方法声明中
             *      3）在使用是无需在实参前加入params
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *  方法：
             *      修饰符     返回值类型    方法名          参数类型    备注
             *                  int         GetSum          params int[]
             */
            #endregion
            //Forms.Line("CP06_08");
            //Mt04Params.CP06_08();

            #region CP06_09：方法的重载
            /*
             *  例程编号：CP06_09
             *  摘要：
             *      方法的重载
             *  说明：
             *      1）方法重载的条件：1.方法名一样；2.参数的个数或类型不一样
             *  步骤：
             *      1）方法一：2个整形变量相加，返回相加之和
             *      2）方法二：2个整形变量相加，返回两字符串相连接的字符串（无法重载）
             *      3）方法三：3个整形变量相加，返回相加之和（和方法一发生重载）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *  方法：
             *      修饰符     返回值类型    方法名          参数类型    备注
             *                  int         GetSum          int,int
             *                  string      GetSum          int,int     无法重载，方法名和参数类型或个数一样
             *                  int         GetSum          int,int,int 可以重载，参数个数不一样
             */
            #endregion
            //Forms.Line("CP06_09");
            //Mt01Method.CP06_09();

            #region CP06_10：方法递归的例程
            /*
             *  例程编号：CP06_10
             *  摘要：
             *      方法递归的例程
             *  说明：
             *      1）方法递归就是在方法里面执行自己
             *      2）注意：
             *          第一，明确方法的功能。（明确需要的条件，确定返回值和参数）
             *          第二，明确递归退出的条件。
             *          第三，找到递归的关系是
             *  步骤：
             *      1）方法1：按照用户的要求次数来输出HelloWorld
             *      2）方法2：实现n的阶乘
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *  方法：
             *      修饰符     返回值类型    方法名          参数类型    备注
             */
            #endregion
            //Forms.Line("CP06_10");
            //Mt01Method.CP06_10();


        }
    }
}
