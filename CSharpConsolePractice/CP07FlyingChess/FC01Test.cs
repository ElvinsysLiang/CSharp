#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 项目名称 ：CP07FlyingChess
 * 项目描述 ：
 * 类 名 称 ：FC01Test
 * 类 描 述 ：飞行棋的测试类
 * 命名空间 ：CP07FlyingChess
 * 机器名称 ：DESKTOP-UPPQS8L
 * CLR 版本 ：4.0.30319.42000
 * 作    者 ：Elvinsys
 * 创建时间 ：2020-03-17 15:06:06
 * 更新时间 ：2020-03-17 15:06:06
 * 版 本 号 ：v1.0.0.0
 ****************************************************************
 * Copyright @ Elvinsys 2020. All rights reserved.
 ****************************************************************
----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Web;

namespace CP07FlyingChess
{
    public class FC01Test
    {
        //定义string[]来存储玩家的名字
        public static string[] PlayerNames = new string[2];
        //定义int[]来存储玩家的状态
        public static bool[] PlayerStatus = new bool[2];
        //定义int[]来存储地图信息
        public static int[] Maps = new int[100];
        //定义int[]来存储玩家的位置
        public static int[] PlayerPos = new int[2];

        //游戏开始
        public static void GameTest_1()
        {
            //游戏头
            GameTitle();
            //提示玩家输入名字
            InputPlayerNames();
            //初始化地图
            InitialMaps();
            Console.WriteLine("地图初始化成功,按任意键开始游戏...");
            Console.ReadKey();
            //清屏
            Console.Clear();
            //绘制地图
            DrawMaps();
            //开始游戏

            while (true)
            {
                if (PlayerStatus[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    PlayerStatus[0] = false;
                }
                if (PlayerPos[0] == 99)
                {
                    Console.WriteLine("恭喜!!!{0}取得了胜利~游戏结束.", PlayerNames[0]);
                    break;
                }
                if (PlayerStatus[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    PlayerStatus[1] = false;
                }
                if (PlayerPos[1] == 99)
                {
                    Console.WriteLine("恭喜!!!{0}取得了胜利~游戏结束.", PlayerNames[1]);
                    break;
                }
            }
        }

        private static void PlayGame(int iPlayerNum)
        {
            Random rdm = new Random();
            int iRdmNum;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("现在是{0}的回合,按任意键掷骰子...", PlayerNames[iPlayerNum]);
            Console.ReadKey();
            iRdmNum = rdm.Next(1,7);
            Console.WriteLine("掷到的点数为:{0},按任意键开始行动...", iRdmNum);
            Console.ReadKey();
            PlayerPos[iPlayerNum] += iRdmNum;
            CheckPos(iPlayerNum);
            if (PlayerPos[iPlayerNum] == PlayerPos[1 - iPlayerNum])
            {
                Console.WriteLine("{0}踩到了{1}的尾巴,{1}后退6格.", PlayerNames[iPlayerNum], PlayerNames[1 - iPlayerNum]);
                PlayerPos[1 - iPlayerNum] -= 6;
                CheckPos(1 - iPlayerNum);
            }
            switch (Maps[PlayerPos[iPlayerNum]])
            {
                case 0:
                    Console.WriteLine("前进了{0}格,然后,并没事发生...", iRdmNum);
                    break;
                case 1:
                    Console.WriteLine("前进了{0}格,不幸踩到了屎,暂停一回合...", iRdmNum);
                    PlayerStatus[iPlayerNum] = true;
                    break;
                case 2:
                    Console.WriteLine("前进了{0}格,向{1}丢了炸弹,{1}后退6格...", iRdmNum,PlayerNames[1-iPlayerNum]);
                    PlayerPos[1 - iPlayerNum] -= 6;
                    CheckPos(1 - iPlayerNum);
                    break;
                case 3:
                    Console.WriteLine("前进了{0}格,踩到了地雷被炸飞,后退6格...", iRdmNum);
                    PlayerPos[iPlayerNum] -= 6;
                    CheckPos(iPlayerNum);
                    break;
                case 4:
                    Console.WriteLine("前进了{0}格,进入了任意门,强制与{1}交换了位置...", iRdmNum,PlayerNames[1-iPlayerNum]);
                    int iTemp = PlayerPos[iPlayerNum];
                    PlayerPos[iPlayerNum] = PlayerPos[1 - iPlayerNum];
                    PlayerPos[1 - iPlayerNum] = iTemp;
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            DrawMaps();
        }

        private static void CheckPos(int playerNum)
        {
            if (PlayerPos[playerNum] < 0)
            {
                PlayerPos[playerNum] = 0;
            }
            if (PlayerPos[playerNum] > 99)
            {
                PlayerPos[playerNum] = 99;
            }
        }

        private static void DrawMaps()
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
            for (int i = 64; i > 34; i--)
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
                DrawStringMap(70 + i);
            }
            Console.WriteLine();
        }

        private static void DrawStringMap(int iPos)
        {
            if(PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == iPos)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("<>");
            }else if (PlayerPos[0] == iPos)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ａ");
            }else if (PlayerPos[1] == iPos)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
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

        private static void InitialMaps()
        {
            /*
             *  地图上有五种地板
             *      0="口"=什么是都没发生
             *      1="Ｘ"=暂停一回合
             *      2="Ｏ"=炸弹，让对方玩家倒退6格
             *      3="＊"=地雷，自己倒退6格
             *      4="Ｄ"=传送门，强制与对方交换位置
             *  地图共有100格，规定1~4种功能格各有5种
             */
            //自动生成随机的功能格，初始化地图
            int x = 0, o = 0, m = 0, d = 0;
            for (int i = 0; i < 100; i = i + 10)
            {
                RamdomPoints(i, ref x, ref o, ref m, ref d);
                Maps[x] = 1;
                Maps[o] = 2;
                Maps[m] = 3;
                Maps[d] = 4;
            }
        }

        private static void RamdomPoints(int i, ref int x, ref int o, ref int m, ref int d)
        {
            Random iRdm = new Random();
            x = iRdm.Next(0, 10);
            o = iRdm.Next(0, 10);
            while (o == x)
            {
                o = iRdm.Next(0, 10);
            }
            m = iRdm.Next(0, 10);
            while (m == x || m == o)
            {
                m = iRdm.Next(0, 10);
            }
            d = iRdm.Next(0, 10);
            while (d == x || d == o || d == m)
            {
                d = iRdm.Next(0, 10);
            }
            x = x + i;
            o = o + i;
            m = m + i;
            d = d + i;
        }

        private static void InputPlayerNames()
        {
            Console.Write("请输入玩家A的名字：");
            PlayerNames[0] = Console.ReadLine();
            while (true)
            {
                if (PlayerNames[1] == "")
                {
                    Console.Write("玩家A的名字不能为空，请重新输入：");
                    PlayerNames[0] = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.Write("请输入玩家B的名字：");
            PlayerNames[1] = Console.ReadLine();
            while (true)
            {
                if (PlayerNames[1] == "")
                {
                    Console.Write("玩家B的名字不能为空，请重新输入：");
                    PlayerNames[1] = Console.ReadLine();
                }
                else if (PlayerNames[0] == PlayerNames[1])
                {
                    Console.Write("玩家B的名字不能和玩家A的名字相同，请重新输入：");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            GameTitle();
            Console.WriteLine("玩家名字输入完毕...");
            Console.WriteLine("玩家—{0}—用Ａ来表示。", PlayerNames[0]);
            Console.WriteLine("玩家—{0}—用Ｂ来表示。", PlayerNames[1]);
            Console.ReadKey();
        }

        private static void GameTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=======2020-03-17  测试=======");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}