#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty10Var
 * 类 描 述 ：var推断类型数据
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-23 16:39:31
 * 更新时间 ：2020-03-23 16:39:31
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP02Types
{
    public class Ty10Var
    {
        #region CP02_25：var的例程
        /*
         *  例程编号：CP02_25
         *  摘要：
         *      var的例程
         *  说明：
         *      1）var：推断数据类型
         *      2）可以用在foreach上
         *  步骤：
         *      1）
         */
        /// <summary>
        /// var的例程
        /// </summary>
        public static void CP02_25()
        {
            //用var定义各种数据并赋值
            var iVar = 1;
            var dVar = 3.14;
            var bVar = true;
            var strVar = "good";
            var chVar = 'c';
            //用Var.GetType()来获取变量的类型
            Console.WriteLine("iVar的类型是：\t" + iVar.GetType());
            Console.WriteLine("dVar的类型是：\t" + dVar.GetType());
            Console.WriteLine("bVar的类型是：\t" + bVar.GetType());
            Console.WriteLine("strVar的类型是：" + strVar.GetType());
            Console.WriteLine("chVar的类型是：\t" + chVar.GetType());

        }
        #endregion


    }
}