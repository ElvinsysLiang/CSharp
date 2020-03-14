#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP02Types
 * 项目描述 ：
 * 类 名 称 ：Ty05Struct
 * 类 描 述 ：结构类型的使用
 * 命名空间 ：CP02Types
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-14 16:09:27
 * 更新时间 ：2020-03-14 16:09:27
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
    //定义学生类型结构
    public struct Student
    {
        public string _name;
        public int _age;
        public Sex _sex;
        public int[] _score;
    }
    public enum Sex
    {
        Female = 0,
        male = 1
    }

    public class Ty05Struct
    {
        #region CP02_18：结构类型的用法
        /*
         *  例程编号：CP02_18
         *  摘要：
         *      结构类型的用法
         *  说明：
         *      1）结构类型用于存放不同类型的一组数据
         *      2）结构类型和枚举类型一样，定义在类型外，命名空间的里面
         *      3）结构类型里面放字段
         *      4）字段用下划线开头的小写字母（Camel）命名方式。
         *  步骤：
         *      1）定义一个学生的结构
         *      2）结构里面有姓名，年龄，性别，语数英三科的成绩
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        public static void CP02_18()
        {
            Student s1;
            s1._name = "Jaco";
            s1._age = 16;
            s1._sex = Sex.Female;
            s1._score = new int[] { 61, 91, 33 };
            //把s1的信息打印到控制台上
            Console.WriteLine("学生的名字叫{0}，今年{1}岁了，是个{2}。\n" +
                "语数英三科的成绩分别是：{3}，{4}，{5}",
                s1._name, s1._age, s1._sex, s1._score[0], s1._score[1], s1._score[2]);
        }
        #endregion
    }
}