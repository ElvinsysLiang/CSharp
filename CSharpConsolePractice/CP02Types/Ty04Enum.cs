#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty04Enum
 * 类 描 述 ：枚举类型数据
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-12 14:18:58
 * 更新时间 ：2020-03-12 14:18:58
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
    public enum Gender
    {
        Male,
        Female
    }
    public enum Orientation
    {
        East,
        South,
        West,
        North
    }
    public enum Building
    {//必须字母开头，用等号赋值
        B220 = 4,
        B217 = 1,
        B219 = 3,
        B218 = 2
    }

    public enum Color
    {
        Red = 1,
        Green = 2,
        Blue = 3
    }

    public enum Fruit
    { 
        Apple=1,
        Orange=2,
        Banana=3
    }

    public class Ty04Enum
    {
        #region CP02_15：简单的枚举例程
        /*
         *  例程编号：CP02_15
         *  摘要：
         *      简单的枚举例程
         *  说明：
         *      1）定义一个枚举类型叫Gender，值有2个：Male，Female
         *      2）枚举类型用enum声明在类外面，命名空间的里面
         *      3）可以通过控制台输出
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 简单的枚举例程
        /// </summary>
        public static void CP02_15()
        {
            Gender sex = Gender.Female;
            Console.WriteLine("您的性别是：" + sex);
        }
        #endregion

        #region CP02_16：枚举类型与int和string间的转换
        /*
         *  例程编号：CP02_16
         *  摘要：
         *      枚举类型与int和string间的转换
         *  说明：
         *      1）任何类型等能转换成string类型数据
         *      2）枚举类型数据转换成string
         *      3）枚举类型数据转换成int
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 枚举类型与int和string间的转换
        /// </summary>
        public static void CP02_16()
        {
            //任何类型数据都能转换成string
            string str;
            //byte转string
            byte b = 1;
            Console.WriteLine("测试byte转string：" + b.ToString());
            //int转string
            int i = 2;
            Console.WriteLine("测试int转string：" + i.ToString());
            //long转string
            long l = 3;
            Console.WriteLine("测试long转string：" + l.ToString());
            //char转string
            char c = 'a';
            Console.WriteLine("测试char转string：" + c.ToString());
            //bool转string
            bool flag = true;
            Console.WriteLine("测试bool转string：" + flag.ToString());
            //double转string
            double dol = 4.4;
            Console.WriteLine("测试double转string：" + dol.ToString());
            //decimal转string
            decimal del = 3.14M;//必须要使用M为后续
            Console.WriteLine("测试decimal转string：" + del.ToString());

            //枚举转string
            //Gender ger2 = Gender.Female;
            Orientation ori = Orientation.East;
            Console.WriteLine("测试枚举转string：" + ori.ToString());

            //枚举转int
            //Orientation里面East在第一，默认是0
            Console.WriteLine("测试枚举转int：" + (int)ori);
            //Building里面219是3号
            Building bNum = Building.B219;
            Console.WriteLine("测试掉乱顺序后的枚举转int：" + (int)bNum);

            CP00Forms.Forms.Cut();

            //int转枚举
            Building bNum2 = (Building)2;
            Console.WriteLine("测试int转枚举：" + bNum2);
        }
        #endregion

        #region CP02_17：枚举类型的转换和输出
        /*
         *  例程编号：CP02_17
         *  摘要：
         *      枚举类型的转换和输出
         *  说明：
         *      1）定义三种颜色，RGB，红绿蓝
         *      2）Enum.GetNames()获取枚举类型的名称常量数组。
         *         也可以用Enum.GetName()来获得指定位置的名称常量。
         *      3）Enum.Parse()获取对应的等效转换对象。
         *          该方法返回的是一个object类型数据，用名称来获取值没毛病
         *          但能不能用值来获取名称呢？
         *          如果像用值来获取常量，其实就是Enum.GetName()的功能了。
         *      4）foreach的应用
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// 枚举类型的转换和输出
        /// </summary>
        public static void CP02_17()
        {
            //先用Enum.GetNames()获得枚举类型名称的字符串数组
            //再通过Enum.Parse()获取对应的转换对象
            //输出是必须{1:D}，来获得数字
            Console.WriteLine("输出Color的内容：");
            foreach (string color in Enum.GetNames(typeof(Color))){
                Console.WriteLine("{0} = {1:D}", color, Enum.Parse(typeof(Color), color));
            }
            CP00Forms.Forms.Cut();

            //Enum.Parse()通过数字获取字符串？

            //Enum.Parse(typeof,value)仲的value，不能是整形常量
            //Console.WriteLine("No.1 fruit is：{0}", Enum.Parse(typeof(Fruit), 1));

            //Enum.Parse(typeof,value)中的value必须是字符串。
            Console.WriteLine("No.1 fruit is：{0}", Enum.Parse(typeof(Fruit), "1"));

            //Enum.Parse(typeof,value)解析出来的是个什么？
            //值——>名称//会出异常，不能这样搞，但为什么上面又能通过"1"来找到枚举名称呢？

            //string strFruit = (string)(Enum.Parse(typeof(Fruit), "1"));
            //Console.WriteLine("No.1 fruit is：{0}", strFruit);
            //名称——>值
            int iFruit = (int)Enum.Parse(typeof(Fruit), "Apple");
            Console.WriteLine("Apple No. is：{0}", iFruit);
        }
        #endregion


    }
}