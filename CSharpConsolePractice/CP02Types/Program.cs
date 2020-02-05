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
            Forms.Rule("CS003");
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
            Forms.Rule("CS004");
            Ty02Variable.ShowScales();

            /*
             *  例程编号：CS005（实现用例）
             *  说明：
             *      （设计用例————Ty02Variable）
             *		1）数据溢出造成的结果
             * 		2）解决数据溢出的方法
             *  摘要：
             *      1）在控制台上打印整形变量数据溢出后的结果
             *      2）解决数据溢出的方法一
             *      3）解决数据溢出的方法二
             */
            Forms.Rule("CS005");
            Ty02Variable.ShowIntMax();
            Ty02Variable.ShowIntMaxPlusOne();
            Ty02Variable.M005Method1();
            Ty02Variable.M005Method2();
        }
    }
}
