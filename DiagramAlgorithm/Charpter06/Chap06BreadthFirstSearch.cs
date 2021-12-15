#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Charpter06
* 项目描述 ：广度优先算法
* 类 名 称 ：Chap06BreadthFirstSearch.cs
* 类 描 述 ：
* 命名空间 ：Charpter06
* 作    者 ：NEETJIN
* 创建时间 ：2021-12-15 17:28
* 更新时间 ：2021-12-15 17:28
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
using System.Collections;
using DA00Forms;

namespace Charpter06
{
    class Animal
    {
        private Animal[] _friends;
        private bool _finded;
        private int _step;
        private string _name;

        public Animal(string name)
        {
            _name = name;
            _finded = false;
            _friends = null;
            _step = 0;
        }

        public bool Finded { get => _finded; set => _finded = value; }
        public Animal[] Friends { get => _friends; set => _friends = value; }
        public int Step { get => _step; set => _step = value; }
        public string Name { get => _name; set => _name = value; }
    }

    class Chap06BreadthFirstSearch
    {
        public static void DA06_03()
        {
            BFS_1();
        }

        private static void BFS_1()
        {
            string name;
            Animal you = new Animal("you");
            Animal claire = new Animal("claire");
            Animal bob = new Animal("bob");
            Animal alice = new Animal("alice");
            Animal peggy = new Animal("peggy");
            Animal anuj = new Animal("anuj");
            Animal thom = new Animal("thom");
            Animal jonny = new Animal("jonny");

            you.Friends = new Animal[] { claire, bob, alice };
            claire.Friends = new Animal[] { thom, jonny };
            bob.Friends = new Animal[] { anuj, peggy };
            alice.Friends = new Animal[] { peggy };

            Console.WriteLine("step is: " + BFS(you, out name));
            Console.WriteLine("his name is: " + name);
        }
        private static int BFS(Animal animal, out string name)
        {
            Animal anichk;
            Queue q = new Queue();
            if (animal.Friends.Length != 0)
            {
                InsertFriends(animal, q);
            }
            while (q.Count != 0)
            {
                anichk = (Animal)q.Dequeue();
                if (anichk.Finded != true)
                {
                    anichk.Finded = true;
                    if (anichk.Name.Substring(anichk.Name.Length - 1) == "m")
                    {
                        name = anichk.Name;
                        return anichk.Step;
                    }
                    else
                    {
                        InsertFriends(anichk, q);
                    }
                }
            }
            name = "no one";
            return -1;
        }
        private static void InsertFriends(Animal animal, Queue q)
        {
            for (int i = 0; i < animal.Friends.Length; i++)
            {
                q.Enqueue(animal.Friends[i]);
                animal.Friends[i].Step = animal.Step + 1;
            }
        }
    }
}
