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
         *          数组
         *          字符串
         *          类（class）
         *          接口（interface）
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
        public static void CP02_02()
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
        /// <summary>
        /// 数据溢出的影响，以及解决方法
        /// </summary>
        public static void CP02_03()
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
        /// <summary>
        /// 两个变量的区别
        /// </summary>
        public static void CP02_04()
        {
            float f1 = 12.34f;//12.34f是float数据，再赋值给float的f1
            float f2 = (float)12.34;//12.34是double数据，要赋值给float的f2必须进行强制类型转换
        }
        #endregion

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
        /// <summary>
        /// 用键盘输入小明买的衣服和裤子的件数，并算出总价
        /// </summary>
        public static void CP02_05()
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
        public static void CP02_06()
        {
            byte a = 3, b = 4;
            //byte c = a + b;//错误
            //a和b虽然都是byte型，但两者相加后的结果会自动转换成int，
            //再赋值给byte的c，需要进行强制类型转换
            byte d = 3 + 4;//正确
            //常量的3和4相加后，结果会根据d的类型自动作调整
        }
        #endregion

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
        /// <summary>
        /// 修改错误代码
        /// </summary>
        public static void CP02_07()
        {
            byte a = 130;//在C#中，byte的取值范围是0~255，因此没毛病
            //但在Java中，byte的取值范围是-128~127，必须通过强转来解决
            Console.WriteLine("byte a = " + a);
        }
        #endregion

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
        /// <summary>
        /// 看结果写代码
        /// </summary>
        public static void CP02_08()
        {
            //helloa1
            Console.WriteLine("hello" + 'a' + 1);
            //98hello
            Console.WriteLine(98+"hello");
            //5 + 555
            Console.WriteLine(5 + " + " + 555);
            //10 = 5 + 5
            Console.WriteLine(5 + 5 + " = 5 + 5");
        }
        #endregion

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
        public static void CP02_09()
        {
            Console.WriteLine("3/4 = " + 3 / 4);//结果是一个整数
            Console.WriteLine("(float)3/4 = " + (float)3 / 4);//结果是一个小数
        }
        #endregion
    }
}
