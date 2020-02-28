﻿#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP02Types
* 项目描述 ：关于数据类型的例程
* 类 名 称 ：Program
* 类 描 述 ：
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP02Types
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-03 16:09:18
* 更新时间 ：2020-02-27 10:32:48
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using CP00Forms;

namespace CP02Types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CP02_01：在控制台上打印各类型的常量
            /*
             *  例程编号：CP02_01
             *  摘要：
             *      在控制台上打印各种类型的常量
             *  说明：
             *      1）常量一般用const修饰
             *  步骤：
             *      1）输出各类型常量（字符串、字符、整数、小数、金钱、布尔、二进制、八进制、十六进制)
             *  变量：
             *      修饰符      变量类型     变量名      说明
             *      const       string      str     
             *      const       char        ch      
             *      const       byte        bytNum  
             *      const       shotr       shoNum
             *      const       int         intNum
             *      const       long        lonNum
             *      const       float       floNum
             *      const       double      douNum
             *      const       decimal     decNum
             *      const       bool        dlag
             *      const       int         intNum2
             *      const       int         intNum3
             *      const       int         intNum4
             *      
             *  方法：
             *      修饰符         返回值类型    方法名        参数1类型  参数2类型   备注
             *      public static   void       ShowConstants  
             */
            #endregion
            //Forms.Line("CP02_01");
            //Ty01Constant.CP02_01();

            #region CP02_02：在控制台上打印各类型变量的取值范围
            /*
             *  例程编号：CP02_02
             *  摘要：
             *      输出各类型变量的取值范围（字符串、字符、整数、小数、金钱)
             *  说明：
             *      1）数据类型主要有以下几种
             *      基本数据类型
             *          数值型
             *              整型
             *                  字节型（byte）	短整型（short）	整型（int）	长整形（long）
             *              浮点型
             *                  单精度浮点型（float）	双精度浮点型（double）
             *              金钱型
             *                  decimal）
             *          非数值型
             *              字符型（char）
             *              布尔型（boolean）
             *      引用数据类型
             *          类（class）
             *          接口（interface）
             *          数组
             * 		2）下面主要测试是Byte,Short,Integer,Long,Float,Double,Charater，除此之外还有Boolean
             * 		3）包装类常用的常量和方法：_VALUE(取值范围),_toString(转为字符串)等等
             *  步骤：
             *      1）
             *  变量：
             *      修饰符      变量类型     变量名      说明
             *  方法：
             *      修饰符         返回值类型    方法名        参数1类型  参数2类型   备注
             *      
             */
            #endregion
            //Forms.Line("CP02_02");
            //Ty02Variable.CP02_02();

            #region CP02_03：数据溢出的影响，以及解决方法
            /*
             *  例程编号：CP02_03
             *  摘要：
             *      数据溢出的影响，以及解决方法
             *  说明：
             *      1）数据溢出造成的结果
             * 		2）解决数据溢出的方法
             *  步骤：
             *      1）在控制台上打印整形变量的最大值
             *      2）在控制台上打印整形变量数据溢出后的结果
             *      3）数据溢出的解决方法一：把其中参与运算的变量强制类型转换
             *      4）数据溢出的解决方法二：把其中参与运算的常量强制类型转换
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_03");
            //Ty02Variable.CP02_03();

            #region CP02_04：两行代码的区别
            /*
             *  例程编号：CP02_04
             *  摘要：
             *      两行代码的区别
             *  说明：
             *      1）两行代码的区别：
             *          float f1 = 12.34f;
             *          float f2 = (float)12.34;
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名     备注
             *  方法：
             *      修饰符     返回值类型    方法名     参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_04");
            //Ty02Variable.CP02_04();

            #region CP02_05：用键盘输入小明买的衣服和裤子的件数，并算出总价
            /*
             *  例程编号：CP02_05
             *  摘要：
             *      用键盘输入小明买的衣服和裤子的件数，并算出总价
             *  说明：
             *      1）商店的T恤35元/件，裤子120元/条，小明买了T恤和裤子，
             *         经理给打8.8折，最后应该给多少钱咧？
             *  步骤：
             *      1）从键盘上获取小明买到的T恤数量
             *      2）从键盘上获取小明买到的裤子数量
             *      3）用键盘输入小明买的衣服和裤子数量，并算出总价
             *  变量：
             *      修饰符             变量类型     变量名           说明
             *                         int         tshNum      T-Shirt的数量 
             *                         int         troNum      Trouser的数量
             *  方法：
             *      修饰符         返回值类型     方法名     参数1类型     参数2类型
             *      public static   int         GetTshNum   void
             *      public static   int         GetTroNum   void
             *      public static   void        Account     void
             */
            #endregion
            //Forms.Line("CP02_05");
            //Ty02Variable.CP02_05();

            #region CP02_06：两行代码的正确性
            /*
             *  例程编号：CP02_06
             *  摘要：
             *      两行代码的正确性
             *  说明：
             *      1）以下两行代码的区别
             *          byte a = 3, b = 4;
             *          byte c = a + b;
             *          byte d = 3 + 4;
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_06");
            //Ty02Variable.CP02_06();

            #region CP02_07：修改错误代码
            /*
             *  例程编号：CP02_07
             *  摘要：
             *      修改错误代码
             *  说明：
             *      1）修改错误代码
             *          byte a = 130;
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_07");
            //Ty02Variable.CP02_07();

            #region CP02_08：看结果写代码
            /*
             *  例程编号：CP02_08
             *  摘要：
             *      看结果写代码
             *  说明：
             *      1）helloa1
             *      2）98hello
             *      3）5 + 555
             *      4）10 = 5 + 5
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_08");
            //Ty02Variable.CP02_08();

            #region CP02_09：两个整数相除
            /*
             *  例程编号：CP02_09
             *  摘要：
             *      两个整数相除
             *  说明：
             *      1）两个整数相除的结果也是整数，要得到小数的结果，必须把其中一个整数强转为浮点型
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_09");
            //Ty02Variable.CP02_09();
        }
    }
}
