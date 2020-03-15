#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP06Method
 * 项目描述 ：
 * 类 名 称 ：Mt02Out
 * 类 描 述 ：out参数的用法
 * 命名空间 ：CP06Method
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-15 15:25:33
 * 更新时间 ：2020-03-15 15:25:33
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP06Method
{
    public class Mt02Out
    {
        #region CP06_03：out参数的例程
        /*
         *  例程编号：CP06_03
         *  摘要：
         *      out参数的例程
         *  说明：
         *      1）声明方法，如：out int i;
         *      2）使用的时候也必须又out，如：test(num,out ret);
         *      3）在方法体内，必须先给各个out参数进行赋值，不能范围未经赋值的out参数
         *      4）如果需要返回多个索引值（结果）呢？
         *  步骤：
         *      1）在整形数组中根据元素值找对应的索引值
         *      2）是否找到，用return返回
         *      3）找到的结果用out参数返回。
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int[]       iArray      要处理的数组
         *                  int         iData       索引值对应的数据
         *                  int         iIndex      接收索引值的结果
         *                  bool        bFlag       是否找到索引值
         *  方法：
         *      修饰符         返回值类型    方法名            参数类型    备注
         */
        /// <summary>
        /// out参数的例程
        /// </summary>
        public static void CP06_03()
        {
            //定义一个整形一维数组
            int[] iArray = { 11, 22, 33, 44, 55 };
            int iData;
            int iIndex;
            bool bFlag;
            //用户输入需要查找的数据
            Console.Write("请输入需要查找的数据：");
            while (true)
            {
                try
                {
                    iData = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("输入的不是一个整形数据，请再次输入：");
                }
            }

            //使用方法进行判断
            bFlag = GetIndex(iArray, iData, out iIndex);
            if (bFlag == false)
            {
                Console.WriteLine("查找索引值失败，程序结束。");
            }
            else
            {
                Console.WriteLine("查找成功，数据{0}的索引值是：{1}", iData, iIndex);
            }

        }
        public static bool GetIndex(int[] iArray, int iData, out int iIndex)
        {
            bool iFlag = true;
            iIndex = -1;
            for (int i = 0; i < iArray.Length; i++)
            {
                if (iArray[i] == iData)
                {
                    iIndex = i;
                    iFlag = true;
                    break;
                }
                if (i == iArray.Length - 1)
                {
                    iFlag = false;
                }
            }
            return iFlag;
        }
        #endregion

        #region CP06_04：out参数求数组各类结果
        /*
         *  例程编号：CP06_04
         *  摘要：
         *      out参数求数组各类结果
         *  说明：
         *      1）数组的最大值
         *      2）最大值的索引
         *      3）数组的最小值
         *      4）最小值的索引
         *      5）数组的和
         *      6）数组的平均值
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  int[]       iArray      需要处理的数组
         *                  bool        iFlag       是否成功求出结果
         *                  int         iMax        最大值
         *                  int         iMaxIndex   最大值的索引值
         *                  int         iMin        最小值
         *                  int         iMinIndex   最小值的索引值
         *                  int         iSum        数组元素值的总和
         *                  int         iAvg        数组元素值的平均值
         *  方法：
         *      修饰符     返回值类型    方法名            参数类型    备注
         *                  bool        GetMaxMinSumAvg     int[]   int int int int int int
         */
        /// <summary>
        /// out参数求数组各类结果
        /// </summary>
        public static void CP06_04()
        {
            //新建整形一维数组
            int[] iArray = { 11, 22, 33, 44, 55 };
            int[] iArray_null = null;
            //需要用到的变量
            int iMax = 0, iMin = 0, iMaxIndex = 0, iMinIndex = 0, iSum = 0, iAvg = 0;
            bool iFlag;
            //使用方法求数组的各类结果
            iFlag = GetMaxMinSumAvg(iArray_null, out iMax, out iMaxIndex, out iMin, out iMinIndex, out iSum, out iAvg);
            if (iFlag == false)
            {
                Console.WriteLine("求解失败。");
            }
            else
            {
                Console.WriteLine("求解成功\n最大值是：{0}，索引号是：{1}\n最小值是：{2}，索引号是：{3}\n总和为：{4}\n平均数为：{5}",
                    iMax, iMaxIndex, iMin, iMinIndex, iSum, iAvg);
            }
        }

        /// <summary>
        /// 求数组的各类结果
        /// </summary>
        /// <param name="iArray">需要处理的数组</param>
        /// <param name="iMax">最大值</param>
        /// <param name="iMaxIndex">最大值的索引值</param>
        /// <param name="iMin">最小值</param>
        /// <param name="iMinIndex">最小值的索引值</param>
        /// <param name="iSum">总和</param>
        /// <param name="iAvg">平均值</param>
        /// <returns></returns>
        public static bool GetMaxMinSumAvg(int[] iArray, out int iMax, out int iMaxIndex, out int iMin, out int iMinIndex, out int iSum, out int iAvg)
        {
            bool bFlag = true;
            iSum = 0;
            iMax = 0;
            iMaxIndex = 0;
            iMin = 0;
            iMinIndex = 0;
            iAvg = 0;
            try
            {
                for (int i = 0; i < iArray.Length; i++)
                {
                    if (iMax < iArray[i])
                    {
                        iMax = iArray[i];
                        iMaxIndex = i;
                    }
                    if (iMin > iArray[i])
                    {
                        iMin = iArray[i];
                        iMinIndex = i;
                    }
                    iSum += iArray[i];
                }
                iAvg = iSum / iArray.Length;
            }
            catch
            {
                bFlag = false;
            }
            return bFlag;
        }
        #endregion

        #region CP06_05：方法实现用户名密码登录程序
        /*
         *  例程编号：CP06_05
         *  摘要：
         *      方法实现用户名密码登录程序
         *  说明：
         *      1）使用out参数输出错误原因
         *      2）用while语句，直到用户名和密码都输入正确
         *  步骤：
         *      1）
         *  变量：
         *      修饰符     变量类型      变量名       备注
         *                  string      strUserName     用户名
         *                  string      strPwd          密码
         *                  string      strMsg          错误信息
         *                  bool        bFlag           用户名密码正确性检验结果
         *  方法：
         *      修饰符     返回值类型    方法名            参数类型    备注
         *                  bool        CheckStatus     string  string  string
         */
        /// <summary>
        /// 方法实现户名密码登录程序
        /// </summary>
        public static void CP06_05()
        {
            string strUserName;
            string strPwd;
            string strMsg;
            bool bFlag = true;
            Console.Write("请输入用户名：");
            strUserName = Console.ReadLine();
            Console.Write("请输入密码：");
            strPwd = Console.ReadLine();
            while (bFlag)
            {
                bFlag = CheckStatus(strUserName, strPwd, out strMsg);
                if (bFlag == true)
                {
                    Console.WriteLine(strMsg + "请重新输入。");
                    Console.Write("请输入用户名：");
                    strUserName = Console.ReadLine();
                    Console.Write("请输入密码：");
                    strPwd = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("登录成功。");
                }
            }
        }

        /// <summary>
        /// 检测用户名和密码的正确性
        /// </summary>
        /// <param name="strUserName">输入的用户名</param>
        /// <param name="strPwd">输入的密码</param>
        /// <param name="strMsg">返回的错误信息</param>
        /// <returns></returns>
        public static bool CheckStatus(string strUserName, string strPwd, out string strMsg)
        {
            bool iFlag = false;
            strMsg = "No Message.";
            if (strUserName != "admin" && strPwd != "8888")
            {
                iFlag = true;
                strMsg = "用户名和密码输入错误。";
            }else if (strUserName != "admin")
            {
                iFlag = true;
                strMsg = "用户名输入错误。";
            }else if (strPwd != "8888")
            {
                iFlag = true;
                strMsg = "密码输入错误。";
            }
            return iFlag;
        }
        #endregion


    }
}