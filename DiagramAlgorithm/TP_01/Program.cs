#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：TP_01
* 项目描述 ：
* 类 名 称 ：Program.cs
* 类 描 述 ：
* 命名空间 ：TP_01
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-4 10:30
* 更新时间 ：2021-12-4 10:30
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
using DA00Forms;
using System.Collections;

namespace TP_01//用于测试或日常练手，建立的测试实例
{
    //class Program
    //{

    //    public static List<Node> NodeList { get; set; }
    //    public static Dictionary<string, int> CostDictionary { get; set; }
    //    public static Dictionary<string, string> ParentDictionary { get; set; }
    //    public static List<string> CheckedNodeName { get; set; }

    //    public Program()
    //    {
    //        NodeList = new List<Node>
    //        {
    //            new Node
    //            {
    //                NodeName = "start",
    //                RelatedNode = new Dictionary<string, int>()
    //                {
    //                    {"A", 6},
    //                    {"B", 2}
    //                }
    //            },
    //            new Node
    //            {
    //                NodeName = "A",
    //                RelatedNode = new Dictionary<string, int>()
    //                {
    //                    {"end", 1}
    //                }
    //            },
    //            new Node
    //            {
    //                NodeName = "B",
    //                RelatedNode = new Dictionary<string, int>()
    //                {
    //                    {"A", 3},
    //                    {"end", 5}
    //                }
    //            },
    //            new Node
    //            {
    //                NodeName = "end",
    //                RelatedNode = new Dictionary<string, int>()
    //            }
    //        };
    //        CostDictionary = new Dictionary<string, int>()
    //        {
    //            {"A",6},
    //            {"B",2},
    //            {"end",int.MaxValue}
    //        };

    //        ParentDictionary = new Dictionary<string, string>()
    //        {
    //            {"A","start"},
    //            {"B","start"},
    //            {"end",""}
    //        };

    //        CheckedNodeName = new List<string>();

    //    }

    //    static void Main(string[] args)
    //    {
    //        var progra = new Program();
    //        Console.WriteLine($"{"parent",10}|{"node",10}|{"cost",10}");
    //        foreach (var item in NodeList.SelectMany(node => node.RelatedNode, (node, relatenode) => new { node.NodeName, relatenode }))
    //        {
    //            Console.WriteLine($"{item.NodeName,10}|{item.relatenode.Key,10}|{item.relatenode.Value,10}");
    //        }

    //        while (CheckedNodeName.Count != CostDictionary.Count)
    //        {
    //            //找到Cost最小的节点
    //            var currentNode = FindMinCostNode(CostDictionary);
    //            //取出relatednode，
    //            if (currentNode != null)
    //            {
    //                //循环如果subNode的Cost小于CostDictionary的Cost
    //                foreach (var subNode in currentNode.RelatedNode)
    //                {
    //                    if (subNode.Value < CostDictionary[subNode.Key])
    //                    {
    //                        //替换
    //                        CostDictionary[subNode.Key] = subNode.Value + CostDictionary[currentNode.NodeName];
    //                        ParentDictionary[subNode.Key] = currentNode.NodeName;
    //                    }
    //                }
    //                CheckedNodeName.Add(currentNode.NodeName);
    //            }
    //        }

    //        Console.WriteLine("最短路径:" + GetTheMinCostPath());

    //        Console.WriteLine("最短路径开销:" + CostDictionary["end"]);

    //        Console.ReadKey();
    //    }

    //    public static string GetTheMinCostPath()
    //    {
    //        bool isStart = false;
    //        string startKey = "end";
    //        string path = "end=>";
    //        while (!isStart)
    //        {

    //            path += ParentDictionary[startKey] + "=>";
    //            startKey = ParentDictionary[startKey];
    //            if (!ParentDictionary.ContainsKey(ParentDictionary[startKey]))
    //            {
    //                path += ParentDictionary[startKey];
    //                isStart = true;
    //            }
    //        }

    //        return path;
    //    }

    //    public static Node FindMinCostNode(Dictionary<string, int> costDictionary)
    //    {
    //        var costItems = costDictionary.Where(c => !CheckedNodeName.Contains(c.Key)).ToList();
    //        if (costItems.Any())
    //        {
    //            var minCostItem = costItems.OrderBy(c => c.Value).First().Key;
    //            return NodeList.FirstOrDefault(n => n.NodeName == minCostItem);
    //        }
    //        return null;
    //    }
    //}

    //public class Node
    //{
    //    public string NodeName { get; set; }
    //    public Dictionary<string, int> RelatedNode { get; set; }
    //}

    //public class CostItem
    //{
    //    public string ParentName { get; set; }
    //    public string NodeName { get; set; }
    //    public int Cost { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrQS = { 0, 48, 24, 12, 13, 85 };
            int[] arrBS = { 0, 12, 13, 24, 48, 85 };

            //测试实例：二分查找
            //测试实例：选择排序
            //测试实例：递归阶乘
            //测试实例：快速排序
            //测试实例：散列表用法
            //测试实例：广度优先算法
            //测试实例：Dijkstra算法
            //测试实例：贪婪算法，广播站例子

            //测试实例：交集
            //List<int> list_1 = new List<int>() { 1, 2, 3, 5, 7, 9 };
            //List<int> list_2 = new List<int>() { 2, 4, 6, 8, 9, 10 };
            //IEnumerable<int> ulist = list_1.Union(list_2);
            //int[] arr = list_1.Union(list_2).ToArray();
            //foreach (int temp in arr)
            //{
            //    Console.WriteLine(temp);
            //}

            Forms.Title("测试实例：Dijkstra算法");
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
            Forms.End();

            Console.ReadKey();
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
                foreach(KeyValuePair<Node,int> kvp in tNode.Neighbour)
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
            foreach(KeyValuePair<Node,int> kvp in dCost)
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
    //创建节点类
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

