#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CP09PathFileStream
* 项目描述 ：关于路径，文件和文件流的例程
* 类 名 称 ：Program
* 类 描 述 ：
* 所在的域 ：LAPTOP-O6ENK577
* 命名空间 ：CP09PathFileStream
* 机器名称 ：LAPTOP-O6ENK577 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Elvinsys
* 创建时间 ：2020-02-23 18:15:00
* 更新时间 ：2020-02-23 18:15:00
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Elvinsys 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using CP00Forms;

namespace CP09PathFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CP09_01：Path的例程
            /*
             *  例程编号：CP09_02
             *  摘要：
             *      Path的例程
             *  说明：
             *      1）使用Path类的方法，不需要实例化
             *      2）Path主要是对文件名和路径的处理
             *      3）使用Path，需在文件头加上：using System.IO;
             *  步骤：
             *      1）获取文件名（含扩展名）
             *      2）获取文件名（不含扩展名）
             *      3）获取扩展名
             *      4）获取文件所在文件夹的名称
             *      5）获取文件的绝对路径
             *      6）合并两个字符串作为文件路径
             */
            #endregion
            //Forms.Line("CP09_01");
            //PFS01Path.CP09_01();

            #region CP09_02：File的例程
            /*
             *  例程编号：CP09_02
             *  摘要：
             *      File的例程
             *  说明：
             *      1）创建文件  File.Create(String).Close()
             *          使用File类，需要在文件头加入：using System.IO;
             *          在C盘创建文件失败，可能权限不够高
             *          无法在不存在的子目录创建，会抛异常
             *          必须以File.Create().Close()创建，否则有可能影响之后的操作（重要！！！
             *      2）复制文件  File.Copy(String,String,Bool)
             *          无法复制到不存在的子目录，会抛异常
             *          若文件创建后，没有执行Close()方法，有可能因文件被其他进程打开而导致复制失败
             *      3）剪切文件  File.Move(String,String,Bool)
             *          无法剪切到不存在的子目录，会抛异常
             *          若文件创建后，没有执行Close()方法，有可能因文件被其他进程打开而导致剪切失败
             *      4）删除文件  File.Delete(String)
             *      5）写入数据
             *          使用Encoding类，需要再文件头加入：using System.Text;
             *          把字符串转换成字节数组：byte[] bArrBuff = Encoding.Default.GetBytes(strData);
             *          以字节数组方式写入文件：File.WriteAllBytes(strFileName, bytBuff);
             *      6）读取数据
             *          以字节数组方式读取文件：bytBuff = File.ReadAllBytes(strFileName);
             *          把字节数组转换成字符串：strData = Encoding.Default.GetString(bytBuff);
             *          
             *          
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP09_02");
            //PFS02File.CP09_02();

            #region CP09_03：File练习
            /*
             *  例程编号：CP09_03
             *  摘要：
             *      File练习
             *  说明：
             *      1）随便写着玩
             *      2）如果绝对路径不是一个完整的路径，将会在程序所在文件夹创建文件。
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP09_03");
            //PFS02File.CP09_03();

            #region CP09_04：使用File实现多媒体文件的复制
            /*
             *  例程编号：CP09_04
             *  摘要：
             *      使用File实现多媒体文件的复制
             *  说明：
             *      1）其实就是一个读写操作
             *      2）与一般的读写操作相比，不需要进行字符串的编码格式转换
             *  步骤：
             *      1）从多媒体文件中读取数据到字节数组中
             *      2）把字节数组写入新建文件中
             */
            #endregion
            //Forms.Line("CP09_04");
            //PFS02File.CP09_04();

            #region CP09_05：File的其他功能
            /*
             *  例程编号：CP09_05
             *  摘要：
             *      File的其他功能
             *  说明：
             *      1）多行写入/插入/读取
             *         File.WriteAllLines(strFileName, strArr); 
             *         File.AppendAllLines(strFileName, strArrAppend);
             *         string[] strArr_new = File.ReadAllLines(strFileName, Encoding.Default);
             *      2）文档写入/插入/读取
             *         File.WriteAllText(strFileName_2, strText);
             *         File.AppendAllText(strFileName_2, strTextAppend);
             *         string strText_new = File.ReadAllText(strFileName_2, Encoding.Default);
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP09_05");
            //PFS02File.CP09_05();

            #region CP09_06：FileStream的例程
            /*
             *  例程编号：CP09_06
             *  摘要：
             *      FileStream的例程
             *  说明：
             *      1）使用FileStream，需要在文件头加入：using System.IO;
             *      2）最好先定义作为缓存，用于读写的字节数组
             *      3）写入数据
             *          FileStream fsWrite = new FileStream(@"d:\fs.txt", FileMode.OpenOrCreate, FileAccess.Write);
             *          把字符串转换成字节数组 byte[] bytArr = Encoding.Default.GetBytes(strFs);
             *          进行写入操作  fsWrite.Write(bytArr, 0, bytArr.Length);
             *          关闭FileStream   fsWrite.Close();
             *          释放FileStream所占用的系统资源 fsWrite.Dispose();
             *          所谓的系统资源，是指在使用异步读写的情况下，对系统其他资源发出请求而占用的资源，如管道，句柄使用等
             *      2）读取数据
             *          FileStream fsRead = new FileStream(@"d:\fs.txt", FileMode.OpenOrCreate, FileAccess.Read)
             *          运用using语句，可以自动释放文件流占用的资源
             *          读取文件的数据，放入字节数组中，并计算读取字节数    int iCount = fsRead.Read(bytBuff, 0, bytBuff.Length);
             *          按照字节数，把以读取的字节数据转换成字符串   string strRead = Encoding.Default.GetString(bytBuff, 0, iCount);
             *          重点：转换的个数是以读取的字节数计算
             *                当一个文件大于字节数组是，可以用while循环进行读取
             *      3）using语句的用法：
             *          引入命名空间
             *          对命名空间改名，使得多个功能类似的命名空间名称上更清晰
             *          定义一个范围，使得范围内代码结束时，通知系统自动回收资源
             *      4）using(){}/FileStream.Close()/FileStream.Dispose()三者区别
             *          1.using(){}除了能用与FileStream以外，还能用于其他对象，但该对象必须继承IDisposable接口
             *          因为FileStream.Dispose()继承了IDisposable接口，因此，无需要在显示进行FileStream.Close()进行资源释放
             *          2.FileStream.Close()是暂时关闭了FileStream，一定时间没有操作，系统做资源回收，短时间内允许重新打开FileStream对象进行操作
             *          3.FileStream.Dispose()是彻底释放FileStream对象占用的资源
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP09_06");
            //PFS03FileStream.CP09_06();

            #region CP09_07：FileStream复制多媒体文件
            /*
             *  例程编号：CP09_07
             *  摘要：
             *      FileStream复制多媒体文件
             *  说明：
             *      1）用户输入源文件路径和目标文件路径
             *      2）判断源文件是否存在
             *      3）若存在，进行文件复制操作
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP09_07");
            //PFS03FileStream.CP09_07();

            #region CP09_08：用FileStream进行文本文件读写
            /*
             *  例程编号：CP09_08
             *  摘要：
             *      StreamWriter/StreamReader
             *  说明：
             *      1）StreamWriter/StreamReader可用于进行文本的读写
             *      2）可用using语句让系统自动回收资源
             *      3）写入文本文件    StreamWriter sw = new StreamWriter(@"d:\sw.txt", true)
             *          1.若文件不存在，则创建，若已存在，则不再创建
             *          2.写入内容不会覆盖文档原有的内容
             *          3.在写入内容时，把文件设置为只读形式
             *      4）读取文本文件    StreamReader sr = new StreamReader(@"d:\sw.txt", true)
             *          1.当行读取  sr.ReadLine()
             *          2.多行读取  sr.ReadToEnd()  /   while(!sr.EndOfStream)sr.ReadToEnd();
             *          3.sr.EndOfStream为只读属性，因此，每次对文本文件的读取最好重新创建StreamReader对象
             *  步骤：
             *      1）
             */
            #endregion
            //Forms.Line("CP09_08");
            //PFS04StreamWriterReader.CP09_08();
        }
    }
}
