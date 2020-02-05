#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP02Types
* 项目描述 ：
* 类 名 称 ：Ty02Variable
* 类 描 述 ：变量的用法
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP02Types
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-05 14:57:21
* 更新时间 ：2020-02-05 14:57:21
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace CP02Types
{
    class Ty02Variable
    {
        /*
         *  例程编号：CS004（实现用例）
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
         *      2）变量的类型主要有是Byte,Short,Integer,Long,Float,Double,Charater，除此之外还有Boolean
         *      3）包装类常用的常量和方法：_VALUE(取值范围),_toString(转为字符串)等等
         *  摘要：
         *      在控制台上打印各种变量的取值范围
         */
        public byte v004BytNum = 1;//无法大于255
        public short v004ShoNum = 256;
        public int v004IntNum = 123456789;
        public long v004LonNum = 12345678910;//在Java中要在末尾加L，C#不需要？
        public float v004FloNum = 12.3456789F;//float浮点数需要在末尾加F
        public double v004DouNum = 12.3456789;
        public decimal v004DecNum = 12.3456789M;//金钱类型需要在末尾加M
        public char v004Ch = 'a';
        public bool v004Flag = true;//没有最大最小值
        public string v004Str = "this is a string";//没有最大最小值
        /// <summary>
        /// 在控制台上打印各种变量的取值范围
        /// </summary>
        public static void ShowScales()
        {
            Console.WriteLine("byte型变量的取值范围是：" + byte.MinValue + "~" + byte.MaxValue);
            Console.WriteLine("short型变量的取值范围是：" + short.MinValue + "~" + short.MaxValue);
            Console.WriteLine("int型变量的取值范围是：" + int.MinValue + "~" + int.MaxValue);
            Console.WriteLine("long型变量的取值范围是：" + long.MinValue + "~" + long.MaxValue);
            Console.WriteLine("float型变量的取值范围是：" + float.MinValue + "~" + float.MaxValue);
            Console.WriteLine("double型变量的取值范围是：" + double.MinValue + "~" + double.MaxValue);
            Console.WriteLine("decimal型变量的取值范围是：" + decimal.MinValue + "~" + decimal.MaxValue);
            Console.WriteLine("char型变量的取值范围是：" + char.MinValue + "~" + char.MaxValue);
        }

        /*
         *  例程编号：CS005（实现用例）
         *  说明：
         *      （设计用例————Ty02Variable）
         *		1）数据溢出造成的结果
         * 		2）解决数据溢出的方法

         *      2）解决数据溢出的方法一
         *      3）解决数据溢出的方法二
         */

        public static int v005IntMax = int.MaxValue;
        /// <summary>
        /// 在控制台上打印整形变量的最大值
        /// </summary>
        public static void ShowIntMax()
        {
            Console.WriteLine("整形变量的最大值是：" + int.MaxValue);
        }
        /// <summary>
        /// 在控制台上打印整形变量数据溢出后的结果
        /// </summary>
        public static void ShowIntMaxPlusOne()
        {
            Console.WriteLine("整形变量的最大值 + 1 = "+ (v005IntMax + 1));
        }
        /// <summary>
        /// 数据溢出的解决方法一：强制类型转换
        /// </summary>
        public static void M005Method1()
        {
            Console.WriteLine("解决方法1：整形变量的最大值 + 1 = " + ((long)v005IntMax + 1));
        }
        /// <summary>
        /// 数据溢出的解决方法二：把其中参与运算的数据强制类型转换
        /// </summary>
        public static void M005Method2()
        {
            Console.WriteLine("解决方法2：整形变量的最大值 + 1 = " + (v005IntMax + 1L));
        }
    }
}
