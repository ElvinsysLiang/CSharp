#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP08ObjectOriented
 * 项目描述 ：
 * 类 名 称 ：OO03Polymorphism
 * 类 描 述 ：多态的使用
 * 命名空间 ：CP08ObjectOriented
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-21 16:27:04
 * 更新时间 ：2020-03-21 16:27:04
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
    public class OO03Polymorphism
    {
        #region CP08_07：多态-里氏转换例程
        /*
         *  例程编号：CP08_07
         *  摘要：
         *      多态-里氏转换
         *  说明：
         *      1）多态，符合里氏转换原则
         *      2）出现父类的地方完全能用子类代替
         *      3）子类的对象能赋值给父类
         *      4）用as关键字可以把父类的对象强转为子类对象（如果数据兼容的话）
         *      5）用is关键字可以检测父类对象是不是子类对象（是的话，返回true）
         *  步骤：
         *      1）创建Person_07类
         *          方法：public void ShowInfo()
         *      2）创建Student_07类
         *          方法：public void ShowInfo()
         *      3）把子类对象赋值给父类对象，用父类对象调用子类方法
         */
        /// <summary>
        /// 多态的例程
        /// </summary>
        public static void CP08_07()
        {
            //子类的对象赋值给父类对象
            Person_07 p1 = new Student_07();
            //父类对象调用父类对象的方法
            p1.ShowInfo();
            //父类对象强转成子类对象
            Student_07 s1 = p1 as Student_07;
            //子类调用子类对象的方法
            s1.ShowInfo();

            CP00Forms.Forms.Cut();

            //子类对象赋值给父类对象
            Person_07 p2 = new Student_07();
            //判断父类对象是不是子类对象
            //如果是，则强转成子类，用子类方法输出
            if (p2 is Student_07)
            {
                Student_07 s2 = p2 as Student_07;
                s2.ShowInfo();
            }
            else
            {
                p2.ShowInfo();
            }
        }
        public class Person_07
        {
            public void ShowInfo()
            {
                Console.WriteLine("这个是父类。");
            }
        }
        public class Student_07 : Person_07
        {
            public new void ShowInfo()
            {
                Console.WriteLine("这是学生类。");
            }
        }
        #endregion

        #region CP08_08：多态-里氏转换练习1
        /*
         *  例程编号：CP08_08
         *  摘要：
         *      多态-里氏转换练习1
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
        /// <summary>
        /// 多态的练习
        /// </summary>
        public static void CP08_08()
        {
            while (true)
            {
                Console.WriteLine("按任意键，ramdon一个1-4的数字，用同一个方法，显示不同的句子...");
                Console.ReadKey();
                Random r = new Random();
                int iVar = r.Next(1, 5);
                Console.WriteLine("随机生成的数字是：" + iVar);

                Person_08[] pArray = new Person_08[5];
                pArray[0] = new Person_08();
                pArray[1] = new Student_08();
                pArray[2] = new Worker_08();
                pArray[3] = new Teacher_08();
                pArray[4] = new Programmer_08();

                #region<假的多态利用方法>
                //switch (iVar)
                //{
                //    case 0:
                //        if (pArray[0] is Person_08)
                //        {
                //            Person_08 s = pArray[0] as Person_08;
                //            s.PersonSayHi();
                //        }
                //        else
                //        {
                //            Console.WriteLine("转换类型失败。");
                //        }
                //        break;
                //    case 1:
                //        if (pArray[0] is Student_08)
                //        {
                //            Student_08 s = pArray[0] as Student_08;
                //            s.StudentSayHi();
                //        }
                //        else
                //        {
                //            Console.WriteLine("转换类型失败。");
                //        }
                //        break;
                //    case 2:
                //        if (pArray[1] is Worker_08)
                //        {
                //            Worker_08 s = pArray[1] as Worker_08;
                //            s.WorkerSayHi();
                //        }
                //        else
                //        {
                //            Console.WriteLine("转换类型失败。");
                //        }
                //        break;
                //    case 3:
                //        if (pArray[2] is Teacher_08)
                //        {
                //            Teacher_08 s = pArray[2] as Teacher_08;
                //            s.TeacherSayHi();
                //        }
                //        else
                //        {
                //            Console.WriteLine("转换类型失败。");
                //        }
                //        break;
                //    case 4:
                //        if (pArray[3] is Programmer_08)
                //        {
                //            Programmer_08 s = pArray[3] as Programmer_08;
                //            s.ProgrammerSayHi();
                //        }
                //        else
                //        {
                //            Console.WriteLine("转换类型失败。");
                //        }
                //        break;
                //}
                #endregion

                //从数组中访问子类的方法

                /*
                 * 父类对象里面，即使装的是子类对象
                 * 若跟父类进行is运算，结果必然是true
                 * 只能是    父类对象 is 子类
                 * 不能是    父类对象 is 父类对象
                 */
                //Console.WriteLine(pArray[1] is Person_08);
                /*if (pArray[iVar] is Person_08)
                {
                    pArray[iVar].PersonSayHi();
                }
                else */
                if (pArray[iVar] is Student_08)
                {
                    ((Student_08)pArray[iVar]).StudentSayHi();
                }
                else if (pArray[iVar] is Worker_08)
                {
                    ((Worker_08)pArray[iVar]).WorkerSayHi();
                }
                else if (pArray[iVar] is Teacher_08)
                {
                    ((Teacher_08)pArray[iVar]).TeacherSayHi();
                }
                else if (pArray[iVar] is Programmer_08)
                {
                    ((Programmer_08)pArray[iVar]).ProgrammerSayHi();
                }
            }
        }
        public class Person_08
        {
            public void PersonSayHi()
            {
                Console.WriteLine("Hi, I am a Person.");
            }
        }
        public class Student_08 : Person_08
        {
            public void StudentSayHi()
            {
                Console.WriteLine("Hi, I am a Studen.");
            }
        }
        public class Worker_08 : Person_08
        {
            public void WorkerSayHi()
            {
                Console.WriteLine("Hi, I am a Worker.");
            }
        }
        public class Teacher_08 : Person_08
        {
            public void TeacherSayHi()
            {
                Console.WriteLine("Hi, I am a Teacher.");
            }
        }
        public class Programmer_08 : Person_08
        {
            public void ProgrammerSayHi()
            {
                Console.WriteLine("Hi, I am a Programmer.");
            }
        }
        #endregion

        #region CP08_09：多态-里氏转换练习2
        /*
         *  例程编号：CP08_09
         *  摘要：
         *      多态-里氏转换练习2
         *  说明：
         *      1）父类Person_09
         *      2）子类Teacher_09 ：Person_09
         *      3）子类Student_09 ：Person_09
         *      4）子类Worker_09 ：Person_09
         *      5）子类Programmer_09 ：Person_09
         *      6）创建Person_09数组，元素个数10个
         *      7）循环random把子类放到Person_09数组中
         *      8）循环用数组中的子类打印信息
         *  步骤：
         *      1）
         */
        /// <summary>
        /// 多态-里氏转换练习2
        /// </summary>
        public static void CP08_09()
        {
            //创建父类的实例数组
            Person_09[] pArray = new Person_09[10];
            //创建random对象
            Random r = new Random();
            //循环创建子类对象，赋值到父类数组中
            for (int i = 0; i < pArray.Length; i++)
            {
                switch (r.Next(0, 4))
                {
                    case 0:
                        pArray[i] = new Teacher_09();
                        break;
                    case 1:
                        pArray[i] = new Student_09();
                        break;
                    case 2:
                        pArray[i] = new Worker_09();
                        break;
                    case 3:
                        pArray[i] = new Programmer_09();
                        break;
                }
            }
            //循环输出父类数组中子类对象的对应的方法
            for (int i = 0; i < pArray.Length; i++)
            {
                if (pArray[i] is Teacher_09)
                {
                    ((Teacher_09)pArray[i]).TeacherSayHi();
                }
                else if (pArray[i] is Student_09)
                {
                    ((Student_09)pArray[i]).StudentSayHi();
                }
                else if (pArray[i] is Worker_09)
                {
                    ((Worker_09)pArray[i]).WorkerSayHi();
                }
                else if (pArray[i] is Programmer_09)
                {
                    ((Programmer_09)pArray[i]).ProgrammerSayHi();
                }
            }
        }
        public class Person_09
        {

        }
        public class Teacher_09 : Person_09
        {
            public void TeacherSayHi()
            {
                Console.WriteLine("Hi, I am a Teacher.");
            }
        }
        public class Student_09 : Person_09
        {
            public void StudentSayHi()
            {
                Console.WriteLine("Hi, I am a Student.");
            }
        }
        public class Worker_09 : Person_09
        {
            public void WorkerSayHi()
            {
                Console.WriteLine("Hi, I am a Worker.");
            }
        }
        public class Programmer_09 : Person_09
        {
            public void ProgrammerSayHi()
            {
                Console.WriteLine("Hi, I am a Programmer.");
            }
        }
        #endregion

        #region CP08_10：多态-虚方法
        /*
         *  例程编号：CP08_10
         *  摘要：
         *      多态-虚方法
         *  说明：
         *      1）继承含有虚方法的类，可以对虚方法进行重写，也可以不重写
         *      2）子类需要对父类方法进行重写，父类该方法要么是虚方法，要么是抽象方法
         *      3）虚方法与抽象方法的区别：
         *          虚方法：    必须有方法体  可以在普通类中定义，也可在抽象类中    子类可重写父类虚方法，也可不重写  
         *          抽象方法：  必须没方法体  必须在抽象类中定义                   子类必须父类的抽象方法重写     
         *  步骤：
         *      1）class Person
         *          属性：StuName
         *          方法：ShowInfo()
         *          虚方法：virtual Eat()
         *      2）class Student : Person
         *          属性：StuName,StrGrade
         *          方法：new ShowInfo()
         *                override Eat()
         */
        public static void CP08_10()
        {
            Person_10 p1 = new Person_10("Jaco");
            p1.ShowInfo();
            p1.Eat();
            CP00Forms.Forms.Cut();

            Student_10 s1 = new Student_10("Lucy", "H1");
            s1.ShowInfo();
            s1.Eat();
        }
        public class Person_10
        {
            private string strName;
            public Person_10() { }
            public Person_10(string strName)
            {
                this.StrName = strName;
            }
            public void ShowInfo()
            {
                Console.WriteLine("原始人的名字叫{0}", StrName);
            }
            public virtual void Eat()
            {
                Console.WriteLine("原始人{0}人要吃肉。",StrName);
            }

            public string StrName { get => strName; set => strName = value; }
        }
        public class Student_10 : Person_10
        {
            private string strGrade;
            public Student_10() { }
            public Student_10(string strName, string strGrade) : base(strName)
            {
                this.StrGrade = strGrade;
            }
            public new void ShowInfo()
            {
                Console.WriteLine("学生的名字叫{0}，班级为{1}", StrName, StrGrade);
            }
            public override void Eat()
            {
                Console.WriteLine("学生{0}喜欢吃寿司。",StrName);
            }

            public string StrGrade { get => strGrade; set => strGrade = value; }
        }
        #endregion

        #region CP08_11：多态-虚方法练习1-改良里氏转换练习2
        /*
         *  例程编号：CP08_11
         *  摘要：
         *      多态-虚方法练习1-改良里氏转换练习2
         *  说明：
         *      1）父类Person_11
         *      2）子类Teacher_11 ：Person_11
         *      3）子类Student_11 ：Person_11
         *      4）子类Worker_11 ：Person_11
         *      5）子类Programmer_11 ：Person_11
         *      6）创建Person_11数组，元素个数10个
         *      7）循环random把子类放到Person_11数组中
         *      8）循环用数组中的子类打印信息
         *  步骤：
         *      1）
         */

        /// <summary>
        /// 多态-虚方法练习1-改良里氏转换练习2
        /// </summary>
        public static void CP08_11()
        {
            //创建Person_11数组，元素个数10个
            Person_11[] pArray = new Person_11[10];
            //循环random把子类放到Person_11数组中
            Random r = new Random();
            int iRam;
            for(int i = 0; i < pArray.Length; i++)
            {
                iRam = r.Next(0,4);
                switch (iRam)
                {
                    case 0:
                        pArray[i] = new Teacher_11();
                        break;
                    case 1:
                        pArray[i] = new Student_11();
                        break;
                    case 2:
                        pArray[i] = new Worker_11();
                        break;
                    case 3:
                        pArray[i] = new Programmer_11();
                        break;
                }
            }
            //循环用数组中的子类打印信息
            for(int i = 0; i < pArray.Length; i++)
            {
                pArray[i].SayHi();
            }
        }

        /// <summary>
        /// 父类Person_11
        /// 虚方法必须有方法体（抽象方法没有方法体）
        /// </summary>
        public class Person_11
        {
            public virtual void SayHi()
            {//虚方法必须有方法体（抽象方法没有方法体）
                Console.WriteLine("Hi, I am a Human.");
            }
        }

        /// <summary>
        /// 子类Teacher_11
        /// 重写虚方法SayHi()
        /// </summary>
        public class Teacher_11 : Person_11
        {
            public override void SayHi()
            {
                Console.WriteLine("Hi, I am a Teacher.");
            }
        }

        /// <summary>
        /// 子类Student_11
        /// 重写虚方法SayHi()
        /// </summary>
        public class Student_11 : Person_11
        {
            public override void SayHi()
            {
                Console.WriteLine("Hi, I am a Student.");
            }
        }

        /// <summary>
        /// 子类Worker_11
        /// 重写虚方法SayHi()
        /// </summary>
        public class Worker_11 : Person_11
        {
            public override void SayHi()
            {
                Console.WriteLine("Hi, I am a Worker.");
            }
        }

        /// <summary>
        /// 子类Programmer_11
        /// 重写虚方法SayHi()
        /// </summary>
        public class Programmer_11 : Person_11
        {
            public override void SayHi()
            {
                Console.WriteLine("Hi, I am a Programmer.");
            }
        }
        #endregion

        #region CP08_12：多态-虚方法练习2-孔子爹案例
        /*
         *  例程编号：CP08_12
         *  摘要：
         *      多态-虚方法练习2-孔子爹案例
         *  说明：
         *      1）
         *  步骤：
         *      1）
         */
        /// <summary>
        /// 多态-虚方法练习2-孔子爹案例
        /// </summary>
        public static void CP08_12()
        {
            //孔子装成他爹，向上转型
            KongFather kf = new Kong();
            Console.WriteLine("我是爹，我的年龄是" + kf.IAge);
            kf.Teach();//用override重写，孔子只会教论语（子类的Teach方法
            //kf.PlayGame();//无法玩游戏

            //向下转型
            Kong k = (Kong)kf;
            Console.WriteLine("我是孔子，我的年龄是" + k.IAge1);
            k.Teach();
            k.PlayGame();
        }
        public class KongFather
        {
            //孔子爹50岁
            private int iAge = 50;

            public int IAge { get => iAge; }
            //孔子爹会教Java
            public virtual void Teach()
            {
                Console.WriteLine("我是爹，我会教Java。");
            }
        }
        public class Kong : KongFather
        {
            //孔子20岁
            private int iAge = 20;

            public int IAge1 { get => iAge; set => iAge = value; }
            //孔子会教论语
            public override void Teach()
            {
                Console.WriteLine("我是孔子，我会教论语。");
            }
            //孔子特有的方法，玩游戏
            public void PlayGame()
            {
                Console.WriteLine("我是孔子，我还会玩游戏。");
            }
        }
        #endregion
    }
}