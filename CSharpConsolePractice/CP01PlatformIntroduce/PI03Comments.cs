#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP01PlatformIntroduce
* 项目描述 ：
* 类 名 称 ：PI03Comments
* 类 描 述 ：文档注释的例程
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP01PlatformIntroduce
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-05 10:03:04
* 更新时间 ：2020-02-05 10:03:04
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace CP01PlatformIntroduce
{
    class PI03Comments
    {
        /*
         *  例程编号：CS002（设计用例）
         *  说明：
         *      文档注释的试用方法。
         *      若要生成.XML文档，可在项目属性--->生成里面设置
         */
        /// <summary>
        /// 该方法用来计算两个整数之和
        /// </summary>
        /// <param name="a">第一个整形参数</param>
        /// <param name="b">第二个整形参数</param>
        /// <returns>返回整形计算结果</returns>
        public static int MyAdd(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 在控制台打印一个整形变量的值
        /// </summary>
        /// <param name="c">需要打印的整形变量参数</param>
        public static void Show(int c)
        {
            Console.WriteLine(c);
        }
    }
}
