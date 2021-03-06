﻿#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP08ObjectOriented
 * 项目描述 ：
 * 类 名 称 ：OO01BasicTest
 * 类 描 述 ：面向对象编程的基本方法
 * 命名空间 ：CP08ObjectOriented
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-18 15:51:50
 * 更新时间 ：2020-03-18 15:51:50
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
    public enum Gender
    {
        Female = 1,
        Male = 2
    }
    public class OO01BasicTest
    {
        #region CP08_01：简单的面向对象程序
        /*
         *  例程编号：CP08_01
         *  摘要：
         *      简单的面向对象程序
         *  说明：
         *      1）测试在类里面实例化类的本身
         *          在类里面可以再定义类，然后实例化该类
         *      2）创建Person类
         *      3）属性：姓名，年龄，性别
         *      4）构造函数：无参构造，有参构造
         *      5）方法：显示人的信息
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// 简单的面向对象程序设计例程
        /// </summary>
        public static void CP08_01()
        {
            //用默认方式实例化Person类
            Person p1 = new Person();
            //对属性进行赋值
            p1.Name = "Jaco";
            p1.Age = 16;
            p1.Gender = Gender.Female;
            //测试ShowInfo()方法
            p1.ShowInfo();

            CP00Forms.Forms.Cut();

            //用带参构造实例化Person类
            Person p2 = new Person("Lucy", 14, Gender.Male);
            //测试ShowInfo()方法
            p2.ShowInfo();
        }

        /// <summary>
        /// 创建Person类
        /// </summary>
        public class Person
        {
            /// <summary>
            /// 创建字段：姓名，年龄，性别
            /// </summary>
            private string _name;
            private int _age;
            private Gender _gender;
            /// <summary>
            /// 封装以上三个字段
            /// </summary>
            public string Name { get => _name; set => _name = value; }
            public int Age { get => _age; set => _age = value; }
            public Gender Gender { get => _gender; set => _gender = value; }
            /// <summary>
            /// 无参构造
            /// </summary>
            public Person() { }
            /// <summary>
            /// 有参构造
            /// </summary>
            /// <param name="name">姓名</param>
            /// <param name="age">年龄</param>
            /// <param name="gender">性别</param>
            public Person(string name, int age, Gender gender)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }
            /// <summary>
            /// 显示姓名、年龄、性别
            /// </summary>
            public void ShowInfo()
            {
                Console.WriteLine("姓名叫{0}，年龄{1}，是个{2}。", Name, Age, Gender);
            }
        }
        #endregion

        #region CP08_02：字段封装，条件检查例程
        /*
         *  例程编号：CP08_02
         *  摘要：
         *      字段封装，条件检查例程
         *  说明：
         *      1）创建Worker类
         *      2）字段：姓名，年龄，证件编号
         *      3）对字段进行封装
         *          姓名：可读可写
         *          年龄：范围是16-65岁，对年龄属性进行检验处理
         *          证件编号：自动生成，只读
         *      4）方法：读取员工信息
         *  步骤：
         *      1）无参构造
         *      2）带参构造
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// 字段封装，条件检查例程
        /// </summary>
        public static void CP08_02()
        {
            //用无参构造实例化Worker类
            Worker w1 = new Worker();
            w1.Name = "Jaco";
            w1.Age = 11;
            //无法给Id属性赋值，是只读属性
            //w1.Id="2222";
            w1.ShowInfo();
            w1.ShowInfo();
            w1.ShowInfo();

            //用带参构造实例化Worker()类
            Worker w2 = new Worker("Lucy", 99);
            w2.ShowInfo();
            w2.ShowInfo();
            w2.ShowInfo();
        }

        //创建Worker类
        public class Worker
        {
            //三个字段：姓名、年龄、员工编号
            private string _name;
            private int _age;
            private string _id;
            private bool _flag;
            /// <summary>
            /// 属性：姓名，任意可读可写
            /// </summary>
            public string Name
            {
                get => _name;
                set => _name = value;
            }
            /// <summary>
            /// 属性：年龄，范围16-65岁
            /// </summary>
            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
                    //对年龄属性进行处理
                    if (value < 16)
                    {
                        Console.WriteLine("年龄不能小于16岁，修改属性值为16.");
                        _age = 16;
                    }
                    else if (value > 65)
                    {
                        Console.WriteLine("年龄不能大于65岁，修改属性值为65.");
                        _age = 65;
                    }
                    else
                    {
                        _age = value;
                    }
                }
            }
            /// <summary>
            /// 属性：Id，自动生成，只读
            /// </summary>
            public string Id
            {
                get
                {
                    if (Flag == false)
                    {
                        Random r = new Random();
                        _id = (r.Next(0, 10)).ToString() + (r.Next(0, 10)).ToString() + (r.Next(0, 10)).ToString() + (r.Next(0, 10)).ToString();
                        Flag = true;
                    }
                    return _id;
                }
            }

            public bool Flag { get => _flag; set => _flag = value; }

            public Worker() { }

            public Worker(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public void ShowInfo()
            {
                Console.WriteLine("员工姓名是{0}，年龄为{1}岁，员工编号：{2}", Name, Age, Id);
            }
        }
        #endregion

        #region CP08_03：静态成员（字段）和非静态成员的区别
        /*
         *  例程编号：CP08_03
         *  摘要：
         *      静态成员（字段）和非静态成员的区别
         *  说明：
         *      1）静态成员属于整个类，不同的实例所共有
         *      2）非静态成员属于实例，不同的实例的非静态成员内存地址不一样
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// 静态成员（字段）和非静态成员的区别
        /// </summary>
        public static void CP08_03()
        {
            //带参构造，实例化对象f1
            FieldTest f1 = new FieldTest(1, 2);
            //输出f1中的两个变量的值
            f1.ShowField();
            CP00Forms.Forms.Cut();
            //无参构造，实例化对象f2
            FieldTest f2 = new FieldTest();
            f2.ShowField();
            //此时，访问f2的StaField的值和f1的是一样的
            //现在，更改f2两个参数的值
            CP00Forms.Forms.Cut();
            f2.IField = 5;
            //f2.StaField = 4;//是静态成员，所以要用类名
            FieldTest.StaField = 4;
            //现在依次访问f1和f2的两个属性
            f1.ShowField();
            f2.ShowField();
            //f1的StaField属性发生了改变，证明该属性是类的所有实例共有的
        }
        public class FieldTest
        {
            /// <summary>
            /// 静态字段
            /// </summary>
            private static int _staField;
            /// <summary>
            /// 非静态字段
            /// </summary>
            private int _iField;
            /// <summary>
            /// 静态属性
            /// </summary>
            public static int StaField { get => _staField; set => _staField = value; }
            /// <summary>
            /// 非静态属性
            /// </summary>
            public int IField { get => _iField; set => _iField = value; }
            /// <summary>
            /// 无参构造函数
            /// </summary>
            public FieldTest() { }
            /// <summary>
            /// 带参构造函数
            /// </summary>
            /// <param name="sF">静态属性赋值</param>
            /// <param name="iF">非静态属性赋值</param>
            public FieldTest(int sF, int iF)
            {
                StaField = sF;//静态字段不能用this
                this.IField = iF;//非静态字段需要this
            }
            /// <summary>
            /// 显示静态属性与非静态属性的值
            /// </summary>
            public void ShowField()
            {
                Console.WriteLine("StaField = {0}, Field = {1}", StaField, IField);
            }
        }
        #endregion

        #region CP08_04：静态方法和非静态方法的区别
        /*
         *  例程编号：CP08_04
         *  摘要：
         *      静态方法和非静态方法的区别
         *  说明：
         *      1）静态方法无需实例化就能用，固定占一块内存
         *      2）非静态方法必须实例化后才能用。
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型    备注
         */
        /// <summary>
        /// 静态方法和非静态方法的区别
        /// </summary>
        public static void CP08_04()
        {
            //测试静态方法
            MethodTest.StaShow();
            //测试非静态方法
            MethodTest mt = new MethodTest();
            mt.Show();
        }
        public class MethodTest
        {
            /// <summary>
            /// 静态方法，能用类名直接使用
            /// </summary>
            public static void StaShow()
            {
                Console.WriteLine("This is static show.");
            }
            /// <summary>
            /// 非静态方法，实例化后才能使用
            /// </summary>
            public void Show()
            {
                Console.WriteLine("This is not static show.");
            }
        }
        #endregion

        #region CP08_05：学生类（练习）
        /*
         *  例程编号：CP08_05
         *  摘要：
         *      学生类（练习）
         *  说明：
         *      1）学生的属性
         *          姓名，年龄（12-17），学生证号（自动生成，只读），语文成绩，数学成绩，英语成绩
         *      2）无参构造函数，带参构造函数
         *      3）非静态方法：基本信息录入，成绩信息录入，信息查询
         *      4）静态方法：三科总成绩，三科平均成绩
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *      private     string      _strName    字段：学生姓名，任意可读可写
         *      private     int         _iAge       字段：年龄，可读可写（12-17）
         *      private     string      _strID      字段：学生证号（自动生成，只读）
         *      private     int         _iChinese   字段：语文成绩，任意可读可写
         *      private     int         _iMath      字段：数学成绩，任意可读可写
         *      private     int         _iEnglish   字段：英语成绩，任意可读可写
         *      private     int         _iSum       字段：三科成绩之和
         *      private     int         _iAvg       字段：三科成绩平均值
         *      public      string      StrName     属性：学生姓名，任意可读可写
         *      public      int         IAge        属性：年龄，可读可写（12-17）
         *      public      string      StrID       属性：学生证号（自动生成，只读）
         *      public     int          IChinese    属性：语文成绩，任意可读可写
         *      public     int          IMath       属性：数学成绩，任意可读可写
         *      public     int          IEnglish    属性：英语成绩，任意可读可写
         *      public     int          ISum        属性：三科成绩之和
         *      public     int          IAvg        属性：三科成绩平均值
         *      
         *  方法：
         *      修饰符     返回值类型    方法名          参数类型      备注
         *      public      void        InputInfo       Student      输入学生信息
         *      public      void        InputScore      Student      输入学生的成绩
         *      public static int       GetSum          Student      返回学生的成绩之和
         *      public static int       GetAvg          Student      返回学生成绩平均值
         */
        /// <summary>
        /// 学生类（练习）
        /// </summary>
        public static void CP08_05()
        {
            //无参构造实例化学生类
            Student s1 = new Student();
            s1.InputInfor();
            s1.InputScore();
            s1.ShowInfo();
            Student.ShowInfo(s1);

            CP00Forms.Forms.Cut();

            //带参构造实例化学生类
            Student s2 = new Student("Lucy", 13, 66, 77, 88);
            s2.ShowInfo();
            Student.ShowInfo(s2);

        }
        public class Student
        {
            private string _strName;
            private int _iAge;
            private string _strID;
            private int _iChinese;
            private int _iMath;
            private int _iEnglish;
            private int _iSum;
            private int _iAvg;

            public string StrName { get => _strName; set => _strName = value; }
            public int IAge
            {
                get
                {
                    return _iAge;
                }
                set
                {
                    if (value < 12)
                    {
                        Console.WriteLine("_iAge字段不能小于12，自动输入12");
                        _iAge = 12;
                    }
                    else if (value > 17)
                    {
                        Console.WriteLine("_iAge字段不能大于12，自动输入17");
                        _iAge = 17;
                    }
                    else
                    {
                        _iAge = value;
                    }
                }
            }
            public string StrID
            {
                get
                {
                    return _strID;
                }
            }
            public int IChinese
            {
                get
                {
                    return _iChinese;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("_iChinese字段不能小于0，自动输入0");
                        _iChinese = 0;
                    }
                    else if (value > 100)
                    {
                        Console.WriteLine("_iChinese字段不能大于100，自动输入100");
                        _iChinese = 100;
                    }
                    else
                    {
                        _iChinese = value;
                    }
                }
            }
            public int IMath
            {
                get
                {
                    return _iMath;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("_iMath字段不能小于0，自动输入0");
                        _iMath = 0;
                    }
                    else if (value > 100)
                    {
                        Console.WriteLine("_iMath字段不能大于100，自动输入100");
                        _iMath = 100;
                    }
                    else
                    {
                        _iMath = value;
                    }
                }
            }
            public int IEnglish
            {
                get
                {
                    return _iEnglish;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("_iEnglish字段不能小于0，自动输入0");
                        _iEnglish = 0;
                    }
                    else if (value > 100)
                    {
                        Console.WriteLine("_iEnglish字段不能大于100，自动输入100");
                        _iEnglish = 100;
                    }
                    else
                    {
                        _iEnglish = value;
                    }
                }
            }
            public int ISum { get => _iSum; set => _iSum = value; }
            public int IAvg { get => _iAvg; set => _iAvg = value; }
            public Student()
            {
                //进行学生证初始化
                Random r = new Random();
                _strID = r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString();
            }
            public Student(string name, int age, int chinese, int math, int english)
            {
                //进行学生证初始化
                Random r = new Random();
                _strID = r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString();
                this.StrName = name;
                this.IAge = age;
                this.IChinese = chinese;
                this.IMath = math;
                this.IEnglish = english;
            }
            public void InputInfor()
            {
                Console.WriteLine("请输入学生基本信息。");
                try
                {
                    Console.Write("姓名：");
                    this.StrName = Console.ReadLine();
                    Console.Write("年龄：");
                    this.IAge = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("学生信息输入有误。");
                }
            }
            public void InputScore()
            {
                Console.WriteLine("请输入学生成绩。");
                try
                {
                    Console.Write("语文成绩：");
                    this.IChinese = Convert.ToInt32(Console.ReadLine());
                    Console.Write("数学成绩：");
                    this.IMath = Convert.ToInt32(Console.ReadLine());
                    Console.Write("英语成绩：");
                    this.IEnglish = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("学生成绩输入有误。");
                }
            }
            public static int GetSum(Student s)
            {
                return s.IChinese + s.IMath + s.IEnglish;
            }
            public static int GetAvg(Student s)
            {
                return (s.IChinese + s.IMath + s.IEnglish) / 3;
            }
            public void ShowInfo()
            {
                Console.WriteLine("信息\t{0}——姓名：{1}\t年龄：{2}", StrID, StrName, IAge);
                Console.WriteLine("成绩\t语文：{0}\t数学：{1}\t英语：{2}\t总分：{3}\t平均成绩：{4}",
                    IChinese, IMath, IEnglish, GetSum(this), GetAvg(this));
            }
            public static void ShowInfo(Student s)
            {
                Console.WriteLine("信息\t{0}——姓名：{1}\t年龄：{2}", s.StrID, s.StrName, s.IAge);
                Console.WriteLine("成绩\t语文：{0}\t数学：{1}\t英语：{2}\t总分：{3}\t平均成绩：{4}",
                    s.IChinese, s.IMath, s.IEnglish, GetSum(s), GetAvg(s));
            }
        }
        #endregion


    }
}