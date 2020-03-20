#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP08ObjectOriented
 * 项目描述 ：
 * 类 名 称 ：OO02Inheritance
 * 类 描 述 ：继承的用法
 * 命名空间 ：CP08ObjectOriented
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-20 19:24:04
 * 更新时间 ：2020-03-20 19:24:04
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP08ObjectOriented
{
    public enum Grade
    {
        S1 = 1,
        S2 = 2,
        S3 = 3,
        H1 = 4,
        H2 = 5,
        H3 = 6
    }
    public class OO02Inheritance
    {
        #region CP08_06：继承的例程
        /*
         *  例程编号：CP08_06
         *  摘要：
         *      继承的例程
         *  说明：
         *      1）继承另一个类
         *          public class Student : Person
         *      2）带参构造函数加入base关键字
         *          public Student(string name,Gender gender,Grade,grade) : base(name,gender)
         *      3）方法重写，需要加入new关键字，用以隐藏基类方法
         *          public new void ShowInfo()
         *  步骤：
         *      1）创建Person类
         *          属性：（姓名，性别）
         *          方法：（显示姓名和性别信息）
         *      2）创建学生类，继承Person类
         *          属性：新增（班级）属性，枚举
         *          方法：（显示姓名、性别和班级信息），方法重写
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// 继承的例程
        /// </summary>
        public static void CP08_06()
        {
            //带参构造Person类
            Person p1 = new Person("Jaco", Gender.Female);
            p1.ShowInfo();

            CP00Forms.Forms.Cut();

            //带参构造Student类
            Student s1 = new Student("Lucy", Gender.Female, Grade.H2);
            s1.ShowInfo();
        }
        /// <summary>
        /// 创建Person类
        /// </summary>
        public class Person
        {
            private string _strName;
            private Gender _gender;

            public string StrName { get => _strName; set => _strName = value; }
            public Gender Gender { get => _gender; set => _gender = value; }
            public Person() { }
            public Person(string name, Gender gender)
            {
                this.StrName = name;
                this.Gender = gender;
            }
            public void ShowInfo()
            {
                Console.WriteLine("这个人的名字叫：{0}，性别：{1}", StrName, Gender);
            }
        }
        /// <summary>
        /// 创建Student类，继承自Person类
        /// </summary>
        public class Student : Person
        {
            private Grade grade;

            public Grade Grade { get => grade; set => grade = value; }
            public Student() { }
            /// <summary>
            /// 带参构造，继承Person类
            /// </summary>
            /// <param name="name">姓名</param>
            /// <param name="gender">性别</param>
            /// <param name="grade">班级</param>
            public Student(string name, Gender gender, Grade grade) : base(name, gender)
            {
                this.Grade = grade;
            }
            /// <summary>
            /// 方法重写，需要加上new关键字
            /// </summary>
            public new void ShowInfo()
            {
                Console.WriteLine("学生的名字：{0}，性别：{1}，年级是：{2}", StrName, Gender, Grade);
            }
        }
        #endregion


    }
}