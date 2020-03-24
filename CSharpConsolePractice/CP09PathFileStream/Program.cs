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


        }
    }
}
