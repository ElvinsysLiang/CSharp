#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP07FlyingChess
 * 项目描述 ：飞行棋游戏
 * 类 名 称 ：Program
 * 类 描 述 ：飞行棋游戏
 * 命名空间 ：CP07FlyingChess
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-14 17:07:00
 * 更新时间 ：2020-03-14 17:07:00
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

/*
 *  说明：
 *      1.玩家为两人
 *      
 */

using System;
using CP00Forms;

namespace CP07FlyingChess
{
    class Program
    {
        //地图总共100格，声明静态整形一维数组储存地图数据
        public static int[] Maps = new int[100];
        //玩家两人，声明静态字符串数组存储玩家姓名
        public static string[] PlayerName = new string[2];
        //声明静态布尔数组存储玩家状态
        public static bool[] PlayerStatus = new bool[2];
        //声明静态整形数组存储玩家当前的位置
        public static int[] PlayerPos = new int[2];

        static void Main(string[] args)
        {
            //显示游戏头
            ShowTitle();
            //提示输入玩家姓名
            Console.ForegroundColor = ConsoleColor.White;
            InputPlayerName(out PlayerName[0], out PlayerName[1]);
            //测试输入的名字,可以在调试监视器里监视变量的变化

            //执行清屏，显示玩家名字
            Console.Clear();
            ShowTitle();
            ShowPlayerName();

            //清屏
            Console.Clear();
            //初始化地图
            InitialMap();
            //画图
            DrawMap();

        }

        private static void DrawMap()
        {
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                DrawStringMap(i);
            }
            Console.WriteLine();
            //第一竖行
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                DrawStringMap(i + 30);
                Console.WriteLine();
            }
            //第二横行
            for(int i = 64; i > 34; i--)
            {
                DrawStringMap(i);
            }
            Console.WriteLine();
            //第二竖行
            for (int i = 0; i < 5; i++)
            {
                DrawStringMap(i + 65);
                Console.WriteLine();
            }
            //第三横行
            for (int i = 0; i < 30; i++)
            {
                DrawStringMap(i+70);
            }
            Console.WriteLine();
        }

        private static void DrawStringMap(int iPos)
        {
            /*
             *  0=没有动作=口
             *  1=暂停=Ｘ
             *  2=炸弹=Ｏ
             *  3=地雷=＊
             *  4=传送门=Ｄ
             */
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == iPos)
            {
                Console.Write("<>");
            }
            else if (PlayerPos[0] == iPos)
            {
                Console.Write("Ａ");
            }
            else if (PlayerPos[1] == iPos)
            {
                Console.Write("Ｂ");
            }
            else
            {
                switch (Maps[iPos])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("口");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ｘ");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Ｏ");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("＊");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ｄ");
                        break;
                }
            }
        }

        private static void InitialMap()
        {
            /*
             *  地图的物种状态
             *      0=没有动作
             *      1=暂停（自己休息一回合）
             *      2=炸弹（对方玩家倒退6格）
             *      3=地雷（自己倒退6格）
             *      4=传送门（跟对方玩家调换位置）
             */
            int[] iArrPausePos = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < iArrPausePos.Length; i++)
            {
                Maps[iArrPausePos[i]] = 1;
            }
            int[] iArrBoomPos = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < iArrBoomPos.Length; i++)
            {
                Maps[iArrBoomPos[i]] = 2;
            }
            int[] iArrLandMinePos = { 9, 27, 60, 93, 2, 7, 8 };
            for (int i = 0; i < iArrLandMinePos.Length; i++)
            {
                Maps[iArrLandMinePos[i]] = 3;
            }
            int[] iArrDoorPos = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < iArrDoorPos.Length; i++)
            {
                Maps[iArrDoorPos[i]] = 1;
            }
        }

        private static void ShowPlayerName()
        {
            Console.WriteLine("玩家A-{0}-用Ａ表示。", PlayerName[0]);
            Console.WriteLine("玩家B-{0}-用Ｂ表示。", PlayerName[1]);
            Console.WriteLine("按任意键继续。");
            Console.ReadKey();
        }

        private static void ShowTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****2020-03-16  飞行棋游戏****");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************");
        }

        private static void InputPlayerName(out string strPlayerNameA, out string strPlayerNameB)
        {
            Console.Write("请输入玩家A的姓名：");
            while (true)
            {
                strPlayerNameA = Console.ReadLine();
                if (strPlayerNameA == "")
                {
                    Console.Write("玩家A的姓名不能为空，请重新输入：");
                }
                else
                {
                    break;
                }
            }
            Console.Write("请输入玩家B的名字：");
            while (true)
            {
                strPlayerNameB = Console.ReadLine();
                if (strPlayerNameB == "")
                {
                    Console.Write("玩家B的名字不能为空，请重新输入：");
                }
                else if (strPlayerNameB == strPlayerNameA)
                {
                    Console.Write("玩家B的名字不能跟玩家A的名字一样，请重新输入：");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
