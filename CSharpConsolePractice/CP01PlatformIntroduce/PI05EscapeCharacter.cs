#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP01PlatformIntroduce
 * 项目描述 ：
 * 类 名 称 ：PI05EscapeCharacter
 * 类 描 述 ：转义字符的用法
 * 命名空间 ：CP01PlatformIntroduce
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-07 17:29:11
 * 更新时间 ：2020-03-07 17:29:11
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP01PlatformIntroduce
{
    public class PI05EscapeCharacter
    {
        #region CP01_04：常用的转义字符
        /*
         *  例程编号：CP01_04
         *  摘要：
         *      常用的转义字符
         *  说明：
         *      1）转义字符其实也是一个字符，而非字符串
         *      2）转义字符可以起到一个功能作用，例如，换行，分隔等等
         *  步骤：
         *      1）常用的转义字符：
         *          换行：\n
         *          退格符：\b
         *          反斜杠：\\
         *          双引号：\"
         *          纵向制表符：\v？
         *          横向制表符：\t
         *          0：\48   \0x30
         *          A：\65   \0x41
         *          a：\97   \0x61
         *      2）字符串中，用@进行批量转义
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
         /// <summary>
         /// 常用的转义字符
         /// </summary>
         public static void CP01_04()
        {
            //char c0, cA, ca;
            Console.WriteLine("现在开始测试转义字符：");
            Console.WriteLine("测试换行符、反斜杠以及双引号：\"\\n\"、\"\\\\\"\n这是第一行\n这是第二行");
            Console.WriteLine("测试退格符：\"\\b\",开始共有abc三个字，现在只有abc\b\bd");
            //退格符不会直接删除，而是用后续的字符把退格的字符覆盖掉
            Console.WriteLine("测试0、A和a，以及横向制表符：\"\\t\"\n字母\t二进制\t十六进制\n0\t{0}\t{1}\nA\t{2}\t{3}\na\t{4}\t{5}",
                (char)48, (char)0x30, (char)65, (char)0x41, (char)97, (char)0x61);
            Console.WriteLine("用@进行批量转义，一般用于文件名路径");
            Console.WriteLine(@"c:\a\b\c\d\test.exe");
            Console.WriteLine("c:\\a\\b\\c\\d\\test.exe");//也可以写成这样，但相对麻烦
        }
        #endregion
    }
}