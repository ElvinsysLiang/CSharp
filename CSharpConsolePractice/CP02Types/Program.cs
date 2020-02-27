#region << 版 本 注 释 >>
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
* 更新时间 ：2020-02-03 16:09:18
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
            /*
             *  例程编号：CS003（实现用例）
             *  说明：
             *      （设计用例————Ty01Constant）
             *      输出常量（字符串、字符、整数、小数、金钱、布尔、二进制、八进制、十六进制)
             *  摘要：
             *      在控制台上打印各种类型的常量
             */
            Forms.Line("CS003");
            Ty01Constant.ShowConstants();

            /*
             *  例程编号：CS004（实现用例）
             *  说明：
             *      （设计用例————Ty02Variable）
             *		1）利用各数据类型的包装类求取值范围
             * 		2）下面主要测试是Byte,Short,Integer,Long,Float,Double,Charater，除此之外还有Boolean
             * 		3）包装类常用的常量和方法：_VALUE(取值范围),_toString(转为字符串)等等
             *  摘要：
             *      在控制台上打印各种类型的常量
             */
            Forms.Line("CS004");
            Ty02Variable.ShowScales();

            /*
             *  例程编号：CS005（实现用例）
             *  说明：
             *      （设计用例————Ty02Variable）
             *		1）数据溢出造成的结果
             * 		2）解决数据溢出的方法
             *  摘要：
             *      1）在控制台上打印整形变量的最大值
             *      2）在控制台上打印整形变量数据溢出后的结果
             *      3）数据溢出的解决方法一：把其中参与运算的变量强制类型转换
             *      4）数据溢出的解决方法二：把其中参与运算的常量强制类型转换
             */
            Forms.Line("CS005");
            Ty02Variable.ShowIntMax();
            Ty02Variable.ShowIntMaxPlusOne();
            Ty02Variable.M005Method1();
            Ty02Variable.M005Method2();

            /*
             *  例程编号：CS006（实现用例）
             *  说明：
             *      两个变量的区别
             *		1）第一个变量本来就是float型
             * 		2）第二个变量原来是double型，强转陈float型
             *  摘要：
             *      
             */
            float f1 = 12.34f;
            float f2 = (float)12.34;

            /*
             *  例程编号：CS007（实现用例）
             *  说明：
             *      （设计用例————Ty02Variable）
             *      商店的T恤35元/件，裤子120元/条，小明买了T恤和裤子，
             *      经理给打8.8折，最后应该给多少钱咧？
             *  摘要：
             *      用键盘输入小明买的衣服和裤子的件数，并算出总价
             */
            Forms.Line("CS007");
            Ty02Variable.Account();
        }
    }
}
