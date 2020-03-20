#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP01PlatformIntroduce
 * 项目描述 ：
 * 类 名 称 ：PI07Stopwatch
 * 类 描 述 ：Stopwatch类的用法
 * 命名空间 ：CP01PlatformIntroduce
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-18 22:21:45
 * 更新时间 ：2020-03-18 22:21:45
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;

namespace CP01PlatformIntroduce
{
    public class PI07Stopwatch
    {
        #region CP01_06：Stopwatch计时器
        /*
         *  例程编号：CP01_06
         *  摘要：
         *      StopWatch计时器
         *  说明：
         *      1）开始计时  .start()
         *      2）结束即使  .stop()
         *      3）统计时间  .Elapsed
         *  步骤：
         *      1）计算自增100000次的时间
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// StopWatch计时器
        /// </summary>
        public static void CP01_06()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i < 100000; i++)
            {
                i += 1;
            }
            sw.Stop();
            Console.WriteLine("耗时：" + sw.Elapsed);
        }
        #endregion
    }
}