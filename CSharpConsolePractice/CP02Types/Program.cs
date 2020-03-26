#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP02Types
* 项目描述 ：关于数据类型的例程
* 类 名 称 ：Program
* 类 描 述 ：
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP02Types
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-03 16:09:18
* 更新时间 ：2020-03-25 11:32:00
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using CP00Forms;

namespace CP02Types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CP02_01：在控制台上打印各类型的常量
            /*
             *  例程编号：CP02_01
             *  摘要：
             *      在控制台上打印各种类型的常量
             *  说明：
             *      1）常量一般用const修饰
             *  步骤：
             *      1）输出各类型常量（字符串、字符、整数、小数、金钱、布尔、二进制、八进制、十六进制)
             *  变量：
             *      修饰符      变量类型     变量名      说明
             *      const       string      str     
             *      const       char        ch      
             *      const       byte        bytNum  
             *      const       shotr       shoNum
             *      const       int         intNum
             *      const       long        lonNum
             *      const       float       floNum
             *      const       double      douNum
             *      const       decimal     decNum
             *      const       bool        dlag
             *      const       int         intNum2
             *      const       int         intNum3
             *      const       int         intNum4
             *      
             *  方法：
             *      修饰符         返回值类型    方法名        参数1类型  参数2类型   备注
             *      public static   void       ShowConstants  
             */
            #endregion
            //Forms.Line("CP02_01");
            //Ty01Constant.CP02_01();

            #region CP02_02：在控制台上打印各类型变量的取值范围
            /*
             *  例程编号：CP02_02
             *  摘要：
             *      输出各类型变量的取值范围（字符串、字符、整数、小数、金钱)
             *  说明：
             *      1）数据类型主要有以下几种
             *      基本数据类型
             *          数值型
             *              整型
             *                  字节型（byte）	短整型（short）	整型（int）	长整形（long）
             *              浮点型
             *                  单精度浮点型（float）	双精度浮点型（double）
             *              金钱型
             *                  decimal）
             *          非数值型
             *              字符型（char）
             *              布尔型（boolean）
             *      引用数据类型
             *          类（class）
             *          接口（interface）
             *          数组
             * 		2）下面主要测试是Byte,Short,Integer,Long,Float,Double,Charater，除此之外还有Boolean
             * 		3）包装类常用的常量和方法：_VALUE(取值范围),_toString(转为字符串)等等
             *  步骤：
             *      1）
             *  变量：
             *      修饰符      变量类型     变量名      说明
             *  方法：
             *      修饰符         返回值类型    方法名        参数1类型  参数2类型   备注
             *      
             */
            #endregion
            //Forms.Line("CP02_02");
            //Ty02Variable.CP02_02();

            #region CP02_03：数据溢出的影响，以及解决方法
            /*
             *  例程编号：CP02_03
             *  摘要：
             *      数据溢出的影响，以及解决方法
             *  说明：
             *      1）数据溢出造成的结果
             * 		2）解决数据溢出的方法
             *  步骤：
             *      1）在控制台上打印整形变量的最大值
             *      2）在控制台上打印整形变量数据溢出后的结果
             *      3）数据溢出的解决方法一：把其中参与运算的变量强制类型转换
             *      4）数据溢出的解决方法二：把其中参与运算的常量强制类型转换
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_03");
            //Ty02Variable.CP02_03();

            #region CP02_04：两行代码的区别
            /*
             *  例程编号：CP02_04
             *  摘要：
             *      两行代码的区别
             *  说明：
             *      1）两行代码的区别：
             *          float f1 = 12.34f;
             *          float f2 = (float)12.34;
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名     备注
             *  方法：
             *      修饰符     返回值类型    方法名     参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_04");
            //Ty02Variable.CP02_04();

            #region CP02_05：用键盘输入小明买的衣服和裤子的件数，并算出总价
            /*
             *  例程编号：CP02_05
             *  摘要：
             *      用键盘输入小明买的衣服和裤子的件数，并算出总价
             *  说明：
             *      1）商店的T恤35元/件，裤子120元/条，小明买了T恤和裤子，
             *         经理给打8.8折，最后应该给多少钱咧？
             *  步骤：
             *      1）从键盘上获取小明买到的T恤数量
             *      2）从键盘上获取小明买到的裤子数量
             *      3）用键盘输入小明买的衣服和裤子数量，并算出总价
             *  变量：
             *      修饰符             变量类型     变量名           说明
             *                         int         tshNum      T-Shirt的数量 
             *                         int         troNum      Trouser的数量
             *  方法：
             *      修饰符         返回值类型     方法名     参数1类型     参数2类型
             *      public static   int         GetTshNum   void
             *      public static   int         GetTroNum   void
             *      public static   void        Account     void
             */
            #endregion
            //Forms.Line("CP02_05");
            //Ty02Variable.CP02_05();

            #region CP02_06：两行代码的正确性
            /*
             *  例程编号：CP02_06
             *  摘要：
             *      两行代码的正确性
             *  说明：
             *      1）以下两行代码的区别
             *          byte a = 3, b = 4;
             *          byte c = a + b;
             *          byte d = 3 + 4;
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_06");
            //Ty02Variable.CP02_06();

            #region CP02_07：修改错误代码
            /*
             *  例程编号：CP02_07
             *  摘要：
             *      修改错误代码
             *  说明：
             *      1）修改错误代码
             *          byte a = 130;
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_07");
            //Ty02Variable.CP02_07();

            #region CP02_08：看结果写代码
            /*
             *  例程编号：CP02_08
             *  摘要：
             *      看结果写代码
             *  说明：
             *      1）helloa1
             *      2）98hello
             *      3）5 + 555
             *      4）10 = 5 + 5
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_08");
            //Ty02Variable.CP02_08();

            #region CP02_09：两个整数相除
            /*
             *  例程编号：CP02_09
             *  摘要：
             *      两个整数相除
             *  说明：
             *      1）两个整数相除的结果也是整数，要得到小数的结果，必须把其中一个整数强转为浮点型
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型         变量名     备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_09");
            //Ty02Variable.CP02_09();

            #region CP02_10：整形一维数组的动态初始化
            /*
             *  例程编号：CP02_10
             *  摘要：
             *      整形一维数组的动态初始化
             *  说明：
             *      1）动态初始化一个整形一维数组
             *      2）这个整形数组有三个元素，并给元素赋值
             *      3）用for语句打印每个元素值
             *      4）？？数组首元素，以及各元素的地址怎么打印？
             *      5）？？？在C#中有必要打印数组的地址吗？
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  int[]       iArray
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_10");
            //Ty03Array.CP02_10();

            #region CP02_11：整形一维数组的静态初始化
            /*
             *  例程编号：CP02_11
             *  摘要：
             *      整形一维数组的静态初始化
             *  说明：
             *      1）静态初始化一个整形一维数组
             *      2）这个整形数组有三个元素，并给元素赋值
             *      3）用for语句打印每个元素值
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  int[]       iArray
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_11");
            //Ty03Array.CP02_11();

            #region CP02_12：数组的基础操作
            /*
             *  例程编号：CP02_12
             *  摘要：
             *      数组的基础操作
             *  说明：
             *      1）初始化数组
             *      2）遍历数组
             *      3）求数组元素最大值
             *      4）求数组元素最小值
             *      5）冒泡排序算法
             *      6）逆序排序算法1
             *      7）逆序排序算法2
             *      8）根据索引值找元素值
             *      9）根据元素值找索引值
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *                  int[]       iArray
             *  方法：
             *      修饰符      返回值类型    方法名      参数1类型  参数2类型  备注
             *                  int[]        InitArray   int                  初始化一个整形一维数组
             *                  void         PrintArray  int[]                遍历整形一维数组
             *                  int          GetMax      int[]                求整形一维数组最大值
             *                  int          GetMin      int[]                求整形一维数组最小值
             *                  int[]        Bubble      int[]                冒泡排序算法
             *                  int[]        Reverse_1   int[]                逆序排序算法1
             *                  int[]        Reverse_2   int[]                逆序排序算法2
             *                  int          GetData     int[]      int       根据索引值找元素值
             *                  int          GetIndex    int[]      int       根据元素值找索引值
             */
            #endregion
            //Forms.Line("CP02_12");
            //Ty03Array.CP02_12();

            #region CP02_13：整形二维数组的动态初始化
            /*
             *  例程编号：CP02_13
             *  摘要：
             *      整形二维数组的动态初始化
             *  说明：
             *      1）
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_13");
            //Ty03Array.CP02_13();

            #region CP02_14：整形二维数组的静态初始化
            /*
             *  例程编号：CP02_14
             *  摘要：
             *      整形二维数组的静态初始化
             *  说明：
             *      1）
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *  方法：
             *      修饰符         返回值类型    方法名            参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_14");
            //Ty03Array.CP02_14();

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
            #endregion
            //Forms.Line("CP02_15");
            //Ty04Enum.CP02_15();

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
            #endregion
            //Forms.Line("CP02_16");
            //Ty04Enum.CP02_16();

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
            #endregion
            //Forms.Line("CP02_17");
            //Ty04Enum.CP02_17();

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
            #endregion
            //Forms.Line("CP02_18");
            //Ty05Struct.CP02_18();

            #region CP02_19：string的用法
            /*
             *  例程编号：CP02_19
             *  摘要：
             *      string的用法
             *  说明：
             *      1）求长度       String.Length
             *      2）转大写       String.ToUpper()
             *      3）转小写       String.ToLower()
             *      4）比较相等     String.Equals（string，StringComparison）
             *      5）分割         String.Split(string,StringSplitOption)
             *      6）分割练习     用户输入xxxx-xx-xx，打印xxxx年xx月xx日
             *      7）替换         String.Replace(String,String)
             *      8）截取         String.SubString(int,int)
             *      9）匹配字符串结尾     String.EndsWith(String)
             *      10）索引值      String.IndexOf(String,int)
             *      11）索引值      String.LastIndexOf(String)
             *      12)索引值练习   文件绝对路径，提取文件名
             *      13）删除空格     String.Trim()
             *      14）空字符串     string.IsNullOrEmpty(String)
             *      15）连接字符串数组 string.Join('Char',String[])
             *      16）字符串变成字符数组   String.ToCharArray()  字符倒序
             *      17）字符串倒序 nice to meet u -> u meet to nice
             *      18）email提取用户名和域名  abc@163.com -> abc 163.com
             *      19）一个字符在字符串中出现的位置与次数
             *      20）字符串内容识别    String.Contains(String)
             *  步骤：
             *      1）
             *  变量：
             *      修饰符     变量类型      变量名       备注
             *  方法：
             *      修饰符     返回值类型    方法名          参数类型    备注
             */
            #endregion
            //Forms.Line("CP02_19");
            //Ty06String.CP02_19();

            #region CP02_20：输出数组名或对象的命名空间
            /*
             *  例程编号：CP02_20
             *  摘要：
             *      输出数组名或对象的命名空间
             *  说明：
             *      1）
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP02_19");
            //Ty06String.CP02_20();

            #region CP02_21：ArrayList的例程
            /*
             *  例程编号：CP02_21
             *  摘要：
             *      ArrayList的例程
             *  说明：
             *      1）数组和可变数组的区别
             *          数组：只能放单一类型数据，长度固定
             *          可变数组：能放多种类型数据，长度可变
             *      2）创建可变数组  ArrayList arrList = new ArrayList();
             *          需要在文件头加入using System.Collections;
             *      3）添加数据  ArrayList.Add(Int/Char/String/Int[]/Class...);
             *      4）添加数组  ArrayList.AddRange(new int[]{Int...});
             *          ArrayList.Add(int[])和ArrayList.AddRange(int[])的区别
             *            ArrayList.Add(int[])是把数组的地址添加到集合中
             *            ArrayList.AddRange(int[])是把数组中的元素按顺序添加到集合中
             *      5）删除指定内容数据  ArrayList.Remove(String);
             *      6）删除指定下标数据  ArrayList.RemoveAt(0);
             *      7）删除下标范围数据  ArrayList.RemoveRange(0,3);
             *      8）清空集合  ArrayList.Clear();
             *      9）升序排列  ArrayList.sort();
             *          无法对含有引用类型数据（包括Array和Classes）的可变数组进行排序
             *          无法对含有不同类型数据的可变数组进行排序
             *      10）顺序逆转  ArrayList.Reverse();
             *      11）指定下标插入数据 ArrayList.Insert(0,String);
             *            插入后，原数据及后面数据的位置往后推一位
             *      12）指定下标插入数组 ArrayList.InsertRange(0, new int[] { Int...});
             *            ArrayList.Insert(2, iArr)ArrayList.InsertRange(3, iArr_1)的区别：
             *            Insert()是把数组地址插入到指定下标位置
             *            InsertRange()是把数组中的元素内容都按顺序插入到指定下标位置
             *      13）指定下标插入可变数组 ArrayList.InsertRange(0, new new ArrayList[]);
             *            Insert()是把集合的地址插入到指定的下标位置
             *            InsertRange()是把集合中的元素内容都按顺序插入到指定下标位置
             *      14）判断是否包含一个指定元素   ArrayList.Contains(String);
             *      15）如果数据是引用类型，如数组名或对象名，可以用is判断后，再处理
             *      16）？？？ArrayList.ToString(),输出的是什么？？？
             *  步骤：
             *      1）创建一个集合，插入各种数据
             *      2）int/double/decimal/string/char/bool/iArray/Person
             */
            #endregion
            //Forms.Line("CP02_21");
            //Ty07ArrayList.CP02_21();

            #region CP02_22：可变数组的长度
            /*
             *  例程编号：CP02_22
             *  摘要：
             *      可变数组的长度
             *  说明：
             *      1）ArrayList.Count()和ArrayList.Capacity()的区别：
             *          Count是可变数组现有的元素的个数
             *          Capacity是可变数组的容量，可以允许存储的元素个数
             *          （集合的容量：当Count超过Capacity是，集合会自动增容：2，4，8，16，31...）
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP02_22");
            //Ty07ArrayList.CP02_22();

            #region CP02_23：StringBuilder的例程
            /*
             *  例程编号：CP02_23
             *  摘要：
             *      StringBuilder的例程
             *  说明：
             *      1）字符串和可变字符串的区别
             *          字符串：长度固定,每次修改进行赋值，实质上是在堆中创建新的字符串
             *          可变字符串：长度可变，可进行追加/移除/替换/插入等操作
             *      2）创建集合  StringBuilder strBuder = new StringBuilder();
             *          需要在文件头加入using System.Text;
             *      3）追加字符串 StringBuilder.Append(Int / Char / String);
             *      4）追加数组 StringBuilder.AppendJoin(Char,StrBuilder);
             *      5）删除下标范围字符 StringBuilder.Remove(Int,Int);
             *      6）删除指定下标数据 StringBuilder.Insert(Int,Char);
             *      7）替换指定内容字符 StringBuilder.Replace(Char,Char);
             *      8）可变字符串大小 StringBuilder.Capacity;
             *          其实容量，和集合一样，容量随着字符串的变化而双倍增加
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP02_23");
            //Ty08StringBuilder.CP02_23();

            #region CP02_24：Hashtable的例程
            /*
             *  例程编号：CP02_24
             *  摘要：
             *      Hashtable的例程
             *  说明：
             *      1）Hashtable：非泛型，可放入任意类型数据作为键值对
             *      2）创建Hashtable，需在文件头加入：using System.Collections;
             *      3）添加数据  Hashtable.Add(Key,Value);
             *      4）循环打印，按照DictionaryEntry键值对的方式，通过foreach打印
             *          打印顺序不一定按照添加数据的顺序进行打印
             *      5）根据键值删除数据  Hashtable.Remove(Key);
             *      6）查询键值存在    Hahtable.Contains;
             *      7）Hashtable的键值的集合   Hashtable.Keys
             *      8）Hashtable的元素值的集合   Hashtable.Keys
             *      9）Hashtable的大小   Hashtable.Count
             *      10）清空Hashtable的所有元素  Hashtable.Clear()
             *      11）键值类型是Int，而且从0开始按顺序，for循环打印
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP02_24");
            //Ty09Hashtable.CP02_24();

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
            #endregion
            //Forms.Line("CP02_25");
            //Ty10Var.CP02_25();

            #region CP02_26：List的例程
            /*
             *  例程编号：CP02_26
             *  摘要：
             *      List的例程
             *  说明：
             *      1）List和ArrayList的区别
             *          List：泛型集合，数据类型固定的可变数组，数据类型不需要强转
             *          ArrayList：能在同一集合中放不同的数据，对数据的处理一般需要强转
             *          而数据的类型转换，一般伴随着拆箱和装箱的过程，影响程序执行效率
             *      2）创建List List<int> intList = new List<int>();
             *      3）添加数据 List.Add(Int / Char / String / Int[] / Class...);
             *      4）添加数组 List.AddRange(new int[] { Int...});
             *      5）删除指定内容数据 List.Remove(Int);
             *          删除在List中不存在的数据，并不会抛异常
             *      6）删除指定下标数据 List.RemoveAt(Index);
             *      7）删除下标范围数据 List.RemoveRange(startIndex,endIndex);
             *          超出范围，会抛异常
             *      8）清空List List.Clear();
             *          执行List.Clear()后，Count=0，而Capacity不变
             *          List.RemoveAll();的用法？？？
             *      9）升序排列 List.sort();
             *          可对非引用数据类型（数组，类）的List进行升序排序（包括string）
             *      10）顺序逆转 List.Reverse();
             *      11）指定下标插入数据 List.Insert(Index, Int);
             *          插入后，原数据及后面数据的位置往后推一位
             *      12）指定下标插入数组 List.InsertRange(0, new int[] { Int...});
             *          与ArrayList的区别：
             *          因为List是泛型集合，不存在像ArrayList需要考虑添加数组地址还是数组各元素的问题
             *      13）List的大小和容量 List.Count;  List.Capacity;
             *          Count为List中元素的个数，Capacity为List的容量
             *          Capacity随着个数的增加而双倍递增
             *          执行List.Clear()后，Count=0，而Capacity不变
             *      14）判断List中是否包含一个指定内容的元素 List.Contains(Int);
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP02_26");
            //Ty11List.CP02_26();

            #region CP02_27：Dictionary的例程
            /*
             *  例程编号：CP02_27
             *  摘要：
             *      Dictionary的例程
             *  说明：
             *      1）与Hashtable的区别：
             *          Dictionary：泛型键值对，键和值的数据类型都分别固定
             *          Hashtable：非泛型键值对，键和值任意数据类型
             *      2）新建Dictionary    Dictionary<int,string> = new Dictionary<int, string>();
             *          因为继承自Object，因此不需要额外加文件头
             *      3）添加数据 Dictionary.Add(Key, Value);
             *      4）循环打印，按照DictionaryEntry键值对的方式，通过foreach打印
             *          因为键值的类型固定，因此打印的顺序与添加数据顺序一样
             *      5）根据键值删除数据 Dictionary.Remove(Key);
             *      6）查询键值存在 Dictionary.ContainsKey(Key);
             *      7）Dictionary的键值的集合 Dictionary.Keys
             *      8）Dictionary的元素值的集合 Dictionary.Values
             *      9）Dictionary的大小 Dictionary.Count
             *      10）清空Dictionary的所有元素 Dictionary.Clear()
             *      11）键值类型是Int，而且从0开始按顺序，for循环打印
             *          如果是for循环，必须根据Key的升序或降序打印，对Key有严格要求
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP02_27");
            //Ty12Dictionary.CP02_27();

            
        }
    }
}
