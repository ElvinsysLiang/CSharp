#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP03Operator
 * 项目描述 ：
 * 类 名 称 ：Op01Arith
 * 类 描 述 ：数学运算符
 * 命名空间 ：CP03Operator
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-02-28 14:28:21
 * 更新时间 ：2020-03-08 14:41:31
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP03Operator
{
    public class Op01Arith
    {
        #region CP03_01：5种基本数学运算符（+，-，*，/，%）
        /*
         *  例程编号：CP03_01
         *  摘要：
         *      5种数学运算符（+，-，*，/，%）
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型         变量名     备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 5种数学运算符（+，-，*，/，%）
        /// </summary>
        public static void CP03_01()
        {
            //Console.WriteLine("1 + 1 = " + 1 + 1);
            //错误，会把1+1解析成字符串
            Console.WriteLine("1 + 1 = " + (1 + 1));
            Console.WriteLine("2 - 1 = " + (2 - 1));
            Console.WriteLine("2 * 3 = " + (2 * 3));
            //Console.WriteLine("2 / 3 = " + (2 / 3));
            //因为两个操作数都是整数，得出的结果也是整数
            Console.WriteLine("2 / 3 =" + (2 / 3f));
            Console.WriteLine("3 % 2 =" + (3 % 2));
        }
        #endregion

        #region CP03_02：另外2种数学运算符：自增和自减运算符（++，--）
        /*
         *  例程编号：CP03_02
         *  摘要：
         *      另外2种数学运算符：自增和自减运算符（++，--）
         *  说明：
         *      1）
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型         变量名     备注
         *                  int             var
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 另外2种数学运算符：自增和自减运算符（++，--）
        /// </summary>
        public static void CP03_02()
        {
            int var = 0;
            Console.WriteLine("现在的  var = " + var);
            Console.WriteLine("执行   var++");
            var++;
            Console.WriteLine("现在的  var = " + var);
            Console.WriteLine("在WriteLine里面执行var++: " + var++);
            Console.WriteLine("现在的  var = " + var);
            Console.WriteLine("--------------------");
            Console.WriteLine("执行   var--");
            var--;
            Console.WriteLine("现在的  var = " + var);
            Console.WriteLine("在WriteLine里面执行var--: " + var--);
            Console.WriteLine("现在的  var = " + var);
        }
        #endregion

        #region CP03_03：自增自减练习：看代码猜数值
        /*
         *  例程编号：CP03_03
         *  摘要：
         *      自增自减练习：看代码猜数值
         *  说明：
         *      1）num1 = 3, num2 = 4;
         *          num3 = ++num1;
         *          num4 = num2--;
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型     变量名     备注
         *                  int         num1
         *                  int         num2
         *                  int         num3
         *                  int         num4
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 自增自减练习：看代码猜数值
        /// </summary>
        public static void CP03_03()
        {
            int num1 = 3;
            int num2 = 4;
            int num3 = ++num1;
            int num4 = num2--;
            Console.WriteLine("num3 = " + num3);
            Console.WriteLine("num4 = " + num4);
        }
        #endregion

        #region CP03_04：用来连接字符串的加法运算符
        /*
         *  例程编号：CP03_04
         *  摘要：
         *      用来连接字符串的加法运算符
         *  说明：
         *      1）加法运算符除了用来做加法运算以外，还可用作连接两个字符串
         *      2）在控制台打印的时候，碰到字符串前，加法运算符起到算术运算的作用
         *          但，当其前面或后面出现字符串是，加法运算符起到连接字符串的作用
         *  步骤：
         *      1）控制台输出("你的名字叫" + "李博士")
         *      2）控制台输出("我的名字叫" + name)
         *      3）控制台输出(5 + 5)
         *      4）控制台输出("狗狗" + 5 + "岁了")
         *  变量：
         *      修饰符      变量类型         变量名     备注
         *                  string          name
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 用来连接字符串的加法运算符
        /// </summary>
        public static void CP03_04()
        {
            string name = "兔子";
            Console.WriteLine("你的名字叫" + "李博士");
            Console.WriteLine("我的名字叫" + name);
            Console.WriteLine(5 + 5);
            Console.WriteLine("狗狗" + 5 + "岁了");
        }
        #endregion

        #region CP03_05：交换两个整形变量值的三种方法
        /*
         *  例程编号：CP03_05
         *  摘要：
         *      交换两个整形变量值的三种方法
         *  说明：
         *      1）  用第三个变量交换数据
         *      2）  只用原来的两个变量交换数据
         *  步骤：
         *      1）  利用第三个变量
         *      2）  利用加减
         *      3）  利用异或
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iVar1       第一个整形变量
         *                  int         iVar2       第二个整形变量
         *                  int         iTemp       用于暂存数据的变量
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         *                      void        Method_1        void        
         *                      void        Method_2        void
         *                      void        Method_3        void
         */
        /// <summary>
        /// 交换两个整形变量值的三种方法
        /// </summary>
        public static void CP03_05()
        {
            Console.WriteLine("测试第一种方法，通过第三个变量交换数据");
            Method_01();
            Console.WriteLine("测试第二种方法，只用原有的两个变量交换数据");
            Method_02();
            Console.WriteLine("测试第三种方法，只用原有的两个变量交换数据");
            Method_03();
        }
        /// <summary>
        /// 用第三个变量交换数据
        /// </summary>
        public static void Method_01()
        {
            int iVar1 = 10, iVar2 = 20, iTemp;
            Console.WriteLine("现在的数值：iVar1 = {0}, iVar2 = {1}", iVar1, iVar2);
            iTemp = iVar1;
            iVar1 = iVar2;
            iVar2 = iTemp;
            Console.WriteLine("改变后的数值：iVar1 = {0}, iVar2 = {1}", iVar1, iVar2);
        }
        /// <summary>
        /// 只用原有的两个变量交换数据，方法一
        /// </summary>
        public static void Method_02()
        {
            int iVar1 = 10, iVar2 = 20;
            Console.WriteLine("现在的数值：iVar1 = {0}, iVar2 = {1}", iVar1, iVar2);
            iVar1 = iVar1 - iVar2;
            iVar2 = iVar1 + iVar2;
            iVar1 = iVar2 - iVar1;
            Console.WriteLine("改变后的数值：iVar1 = {0}, iVar2 = {1}", iVar1, iVar2);
        }
        /// <summary>
        /// 只用原有的两个变量交换数据，方法二
        /// </summary>
        public static void Method_03()
        {
            int iVar1 = 10, iVar2 = 20;
            Console.WriteLine("现在的数值：iVar1 = {0}, iVar2 = {1}", iVar1, iVar2);
            iVar1 = iVar1 ^ iVar2;
            iVar2 = iVar1 ^ iVar2;
            iVar1 = iVar1 ^ iVar2;
            Console.WriteLine("改变后的数值：iVar1 = {0}, iVar2 = {1}", iVar1, iVar2);
        }
        #endregion

        #region CP03_06：用户输入x天，计算出是几周零几天
        /*
         *  例程编号：CP03_06
         *  摘要：
         *      用户输入x天，计算出是几周零几天
         *  说明：
         *      1）接收用户的天数
         *      2）对天数的处理，并把结果输出到控制台上
         *          iDay = x % 7;
         *          iWeek = x / 7;
         *  步骤：
         *      1）处理天数，算出几周几天，输出到控制台上
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iDay
         *  方法：
         *      修饰符      返回值类型      方法名           参数类型    备注
         *                  void           DayWeek          int 
         */
        /// <summary>
        /// 用户输入x天，计算出是几周零几天
        /// </summary>
        public static void CP03_06()
        {
            int iDay;
            Console.Write("请输入要计算的天数：");
            iDay = Convert.ToInt32(Console.ReadLine());
            DayWeek(iDay);
        }
        /// <summary>
        /// 处理天数，算出几周几天，输出到控制台上
        /// </summary>
        /// <param name="x">需要计算的天数</param>
        public static void DayWeek(int x)
        {
            int iDay, iWeek;
            iDay = x % 7;
            iWeek = x / 7;
            Console.WriteLine("{0}天，是{1}周{2}天", x, iWeek, iDay);
        }
        #endregion

        #region CP03_07：用户输入x秒，计算出几天几小时几分几秒
        /*
         *  例程编号：CP03_07
         *  摘要：
         *      用户输入x秒，计算出几天几小时几分几秒
         *  说明：
         *      1）接收用户的秒数
         *      2）对秒数的处理，并把结果输出到控制台上
         *          iSec = x % 60;
         *          iMin = x / 60 % 60;
         *          iHour = x / (60*60) % 24;
         *          iDay = x / (60*60*24)
         *          
         *  步骤：
         *      1）处理秒数，算出几天几小时几分几秒，输出到控制台上
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int         iX
         *  方法：
         *      修饰符         返回值类型       方法名          参数类型    备注
         *                      void           DyHrMnSc          int
         */
        /// <summary>
        /// 用户输入x秒，计算出几天几小时几分几秒
        /// </summary>
        public static void CP03_07()
        {
            Console.Write("请输入需要计算的秒数：");
            int iX = Convert.ToInt32(Console.ReadLine());
            DyHrMnSc(iX);
        }
        /// <summary>
        /// 处理秒数，算出几天几小时几分几秒，输出到控制台上
        /// </summary>
        /// <param name="x">需要计算的秒数</param>
        public static void DyHrMnSc(int x)
        {
            int iSec = x % 60;
            int iMin = x / 60 % 60;
            int iHour = x / (60 * 60) % 24;
            int iDay = x / (60 * 60 * 24);
            Console.WriteLine("{0}秒，就是{1}天{2}时{3}分{4}秒", x, iDay, iHour, iMin, iSec);
        }
        #endregion


    }
}