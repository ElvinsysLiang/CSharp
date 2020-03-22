#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CO08ObjectOriented
 * 项目描述 ：面向对象编程
 * 类 名 称 ：Program
 * 类 描 述 ：面向对象编程
 * 命名空间 ：CO08ObjectOriented
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-18 13:15:00
 * 更新时间 ：2020-03-18 13:15:00
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

/*
 *  面向对象变成
 *      1.
 */

using System;
using CP00Forms;

namespace CP08ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CP08_01：简单的面向对象程序
            /*
             *  例程编号：CP08_01
             *  摘要：
             *      简单的面向对象程序
             *  说明：
             *      1）测试在类里面实例化类的本身
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
            #endregion
            //Forms.Line("CP08_01");
            //OO01BasicTest.CP08_01();

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
            #endregion
            //Forms.Line("CP08_02");
            //OO01BasicTest.CP08_02();

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
            #endregion
            //Forms.Line("CP08_03");
            //OO01BasicTest.CP08_03();

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
            #endregion
            //Forms.Line("CP08_04");
            //OO01BasicTest.CP08_04();

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
            #endregion
            //Forms.Line("CP08_05");
            //OO01BasicTest.CP08_05();

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
            #endregion
            //Forms.Line("CP08_06");
            //OO02Inheritance.CP08_06();

            #region CP08_07：多态的例程
            /*
             *  例程编号：CP08_07
             *  摘要：
             *      多态的例程
             *  说明：
             *      1）多态，符合里氏转换原则
             *      2）出现父类的地方完全能用子类代替
             *      3）子类的对象能赋值给父类
             *  步骤：
             *      1）创建Person类
             *          方法：public void ShowInfo()
             *      2）创建Student类
             *          方法：public void ShowInfo()
             *      3）把子类对象赋值给父类对象，用父类对象调用子类方法
             */
            #endregion
            //Forms.Line("CP08_07");
            //OO03Polymorphism.CP08_07();

            #region CP08_08：多态的练习1
            /*
             *  例程编号：CP08_08
             *  摘要：
             *      多态的练习1
             *  说明：
             *      1）is运算：父类对象 is 子类
             *      2）父类对象 is 父类，比人返回true，即便父类对象里面是子类对象
             *  步骤：
             *      1）Person_08类
             *          方法：PersonSayHi()
             *      2）Student_08类   继承Person_08类
             *          方法：StudentSayHi()
             *      3）Worker_08类    继承Person_08类
             *          方法：WorkerSayHi()
             *      4）Teacher_08类   继承Person_08类
             *          方法：TeacherSayHi()
             *      5）Programmer_08类    继承Person_08类
             *          方法：ProgrammerSayHi()
             */
            #endregion
            //Forms.Line("CP08_08");
            //OO03Polymorphism.CP08_08();

            #region CP08_09：多态的练习2
            /*
             *  例程编号：CP08_09
             *  摘要：
             *      多态的练习2
             *  说明：
             *      1）父类Person
             *      2）子类Teacher ：Person
             *      3）子类Student ：Person
             *      4）子类Worker ：Person
             *      5）子类Programmer ：Person
             *      6）创建Person数组，元素个数10个
             *      7）循环random把子类放到Person数组中
             *      8）循环用数组中的子类打印信息
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP08_09");
            //OO03Polymorphism.CP08_09();

            #region CP08_10：集合的例程
            /*
             *  例程编号：CP08_10
             *  摘要：
             *      集合的例程
             *  说明：
             *      1）数组和集合的区别
             *          数组：只能放单一类型数据，长度固定
             *          集合：能放多种类型数据，长度可变
             *      2）创建集合  ArrayList arrList = new ArrayList();
             *      3）需要加入  using System.Collections;
             *      4）添加数据  ArrayList.Add(Int/Char/String/Int[]/Class...);
             *      5）删除指定内容数据  ArrayList.Remove(String);
             *      6）删除指定下标数据  ArrayList.RemoveAt(0);
             *      7）删除下标范围数据  ArrayList.RemoveRange(0,3);
             *      8）清空集合  ArrayList.Clear();
             *      9）升序排列  ArrayList.sort();
             *            无法对含有引用类型数据（包括Array和Classes）的集合进行排序
             *            无法对含有不同类型数据的集合进行排序
             *      10）顺序逆转  ArrayList.Reverse();
             *      11）指定下标插入数据 ArrayList.Inser(0,String);
             *            插入后，原数据及后面数据的位置往后推一位
             *      12）指定下标插入数组 ArrayList.InserRange(0, new int[] { Int...});
             *            ArrayList.Insert(2, iArr)ArrayList.InsertRange(3, iArr_1)的区别：
             *            Insert()是把数组地址插入到指定下标位置
             *            InsetRange()是把数组中的元素内容都按顺序插入到指定下标位置
             *      13）指定下标插入集合 ArrayList.InserRange(0, new new ArrayList[]);
             *            Insert()是把集合的地址插入到指定的下标位置
             *            InsetRange()是把集合中的元素内容都按顺序插入到指定下标位置
             *      14）判断指定下标是否包含一个元素   ArrayList.Contains(String);
             *      15）如果数据是引用类型，如数组名或对象名，可以用is判断后，再处理
             *  步骤：
             *      1）创建一个集合，插入各种数据
             *      2）int/double/decimal/string/char/bool/iArray/Person
             */
            #endregion
            //Forms.Line("CP08_10");
            //OO04ArrayList.CP08_10();



        }
    }
}