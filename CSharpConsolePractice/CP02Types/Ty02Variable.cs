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
        #region CS005：在控制台上打印各类型变量的取值范围
        /*
         *  例程编号：CS005
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
        /// <summary>
        /// 输出各类型变量的取值范围（字符串、字符、整数、小数、金钱)
        /// </summary>
        public static void CS005()
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
        #endregion

        #region CS006：数据溢出的影响，以及解决方法
        /*
         *  例程编号：CS006
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
        /// <summary>
        /// 数据溢出的影响，以及解决方法
        /// </summary>
        public static void CS006()
        {
            ShowIntMax();
            ShowIntMaxPlusOne();
            IntMaxChange1();
            IntMaxChange2();
        }

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
            int intMax = int.MaxValue;
            Console.WriteLine("整形变量的最大值 + 1 = "+ (intMax + 1));
        }

        /// <summary>
        /// 数据溢出的解决方法一：把其中参与运算的变量强制类型转换
        /// </summary>
        public static void IntMaxChange1()
        {
            int intMax = int.MaxValue;
            Console.WriteLine("解决方法1：整形变量的最大值 + 1 = " + ((long)intMax + 1));
        }

        /// <summary>
        /// 数据溢出的解决方法二：把其中参与运算的常量强制类型转换
        /// </summary>
        public static void IntMaxChange2()
        {
            int intMax = int.MaxValue;
            Console.WriteLine("解决方法2：整形变量的最大值 + 1 = " + (intMax + 1L));
        }
        #endregion




        #region CS008：用键盘输入小明买的衣服和裤子的件数，并算出总价
        /*
         *  例程编号：CS008
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
        /// <summary>
        /// 用键盘输入小明买的衣服和裤子的件数，并算出总价
        /// </summary>
        public static void CS008()
        {
            int tshNum, troNum;
            tshNum = GetTshNum();
            troNum = GetTroNum();
            Account(tshNum, troNum);
        }

        /// <summary>
        /// 从键盘上获取小明买到的T恤数量
        /// </summary>
        /// <returns>买到的T恤的数量</returns>
        public static int GetTshNum()
        {
            int TshNum;
            Console.Write("请输入小明买到的T恤的数量：");
            TshNum =  Convert.ToInt32(Console.ReadLine());
            while (TshNum < 0)
            {
                Console.Write("输入的数量不得少于0件，请重新输入：");
                TshNum = Convert.ToInt32(Console.ReadLine());
            }
            return TshNum;
        }
        /// <summary>
        /// 从键盘上获取小明买到裤子的数量
        /// </summary>
        /// <returns>买到的裤子的数量</returns>
        public static int GetTroNum()
        {
            int TroNum;
            Console.Write("请输入小明买到的裤子的数量：");
            TroNum = Convert.ToInt32(Console.ReadLine());
            while (TroNum < 0)
            {
                Console.Write("输入的数量不得少于0件，请重新输入：");
                TroNum = Convert.ToInt32(Console.ReadLine());
            }
            return TroNum;
        }
        /// <summary>
        /// 用键盘输入小明买的衣服和裤子数量，并算出总价
        /// </summary>
        public static void Account(int tshNum, int troNum)
        {
            decimal result = (decimal)((tshNum * 35.00 + troNum * 120.00) * 0.88);
            Console.WriteLine("小明买了" + tshNum + "件的T恤和" + troNum + "条裤子，" +
                "经理给打8.8折后，最后小明应付" + result + "元");
        }
        #endregion
    }
}
