#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter07
* 项目描述 ：
* 类 名 称 ：Chap07Dijkstra.cs
* 类 描 述 ：
* 命名空间 ：Charpter06
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-16 18:40
* 更新时间 ：2021-12-16 18:40
* 版 本 号 ：V0.0.0.1
* ======================================
* 历史更新记录
* 版 本 号：V         
* 修改时间：         
* 修改人：
* 修改内容：
* ======================================
*******************************************************************
* Copyright @ NEETJIN 2021-2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion << 版 本 注 释 >>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter07
{
    class Chap07Dijkstra
    {
        public static void DA07_01()
        {
            //初始化图
            Node start = new Node("start");
            Node end = new Node("end");
            Node a = new Node("a");
            Node b = new Node("b");
            //初始化邻居节点
            start.Neighbour.Add(a, 6);
            start.Neighbour.Add(b, 2);
            a.Neighbour.Add(end, 1);
            b.Neighbour.Add(a, 3);
            b.Neighbour.Add(end, 5);
            //创建费用表
            Dictionary<Node, int> dCost = new Dictionary<Node, int>();
            dCost.Add(a, 6);
            dCost.Add(b, 2);
            dCost.Add(end, int.MaxValue);
            //创建父节点表
            Dictionary<Node, Node> dParent = new Dictionary<Node, Node>();
            dParent.Add(a, start);
            dParent.Add(b, start);
            dParent.Add(end, null);
            //求起点到终点的最短距离
            Console.WriteLine("The distance of start to end is: " +
                GetLowestCost(end, dCost, dParent));
            //求起点到终点的最短路径
            PrintRoute(end, dParent);
        }


        private static void PrintRoute(Node node, Dictionary<Node, Node> dParent)
        {
            if (node.Name == "start")
            {
                Console.Write("start->");
            }
            else
            {
                PrintRoute(dParent[node], dParent);
                if (node.Name == "end")
                {
                    Console.WriteLine("end");
                }
                else
                {
                    Console.Write(node.Name + "->");
                }
            }
        }

        private static int GetLowestCost(Node end, Dictionary<Node, int> dCost, Dictionary<Node, Node> dParent)
        {
            Node tNode = GetLowestNode(dCost);
            while (tNode != null)
            {
                tNode.Check = true;
                foreach (KeyValuePair<Node, int> kvp in tNode.Neighbour)
                {
                    if ((dCost[tNode] + kvp.Value) < dCost[kvp.Key])
                    {
                        dCost[kvp.Key] = dCost[tNode] + kvp.Value;
                        dParent[kvp.Key] = tNode;
                    }
                }
                tNode = GetLowestNode(dCost);
            }
            return dCost[end];
        }

        private static Node GetLowestNode(Dictionary<Node, int> dCost)
        {
            Node tNode = null;
            int tCost = int.MaxValue;
            foreach (KeyValuePair<Node, int> kvp in dCost)
            {
                if (kvp.Key.Check != true && kvp.Value < tCost)
                {
                    tCost = kvp.Value;
                    tNode = kvp.Key;
                }
            }
            return tNode;
        }
    }
    class Node
    {
        private string _name;
        private bool _check;
        private Dictionary<Node, int> _neighbour;
        public Node(string name)
        {
            _name = name;
            _check = false;
            _neighbour = new Dictionary<Node, int>();
        }
        public string Name { get => _name; set => _name = value; }
        public bool Check { get => _check; set => _check = value; }
        internal Dictionary<Node, int> Neighbour { get => _neighbour; set => _neighbour = value; }
    }
}
