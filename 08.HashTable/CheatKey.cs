﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HashTable
{
    internal class CheatKey
    {
        private Dictionary<string, Action> cheatDic;
        private Action cheatToRun;

        public CheatKey()
        {
            cheatDic = new Dictionary<string, Action>();
            cheatDic.Add("show me the money", ShowMeTheMoney);
            cheatDic.Add("there is no cow level", ThereIsNoCowLevel);
            cheatDic.Add("black sheep wall", BlackSheepWall);
        }
        public void Run(string cheatKey)
        {
            cheatDic.TryGetValue(cheatKey, out cheatToRun);
            cheatToRun?.Invoke();
        }
        public void ShowMeTheMoney()
        {
            Console.WriteLine("골드를 늘려주는 치트키 발동!");
        }
        public void ThereIsNoCowLevel()
        {
            Console.WriteLine("바로 승리합니다 치트키 발동!");
        }
        public void BlackSheepWall()
        {
            Console.WriteLine("맵핵 치트키 발동!");
        }
    }
}
