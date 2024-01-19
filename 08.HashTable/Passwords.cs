using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HashTable
{
    internal class Passwords
    {
        /* 백준 17219 : https://www.acmicpc.net/problem/17219

        입력: 
        16 4
        noj.am IU
        acmicpc.net UAENA
        startlink.io THEKINGOD
        google.com ZEZE
        nate.com VOICEMAIL
        naver.com REDQUEEN
        daum.net MODERNTIMES
        utube.com BLACKOUT
        zum.com LASTFANTASY
        dreamwiz.com RAINDROP
        hanyang.ac.kr SOMEDAY
        dhlottery.co.kr BOO
        duksoo.hs.kr HAVANA
        hanyang-u.ms.kr OBLIVIATE
        yd.es.kr LOVEATTACK
        mcc.hanyang.ac.kr ADREAMER
        startlink.io
        acmicpc.net
        noj.am
        mcc.hanyang.ac.kr

        출력:
        THEKINGOD
        UAENA
        IU
        ADREAMER
        */

        static void Main1()
        {
            string[] args = Console.ReadLine().Split();
            int N = int.Parse(args[0]);
            int M = int.Parse(args[1]);

            Dictionary<string, string> passwords = new Dictionary<string, string>();
            for (int i = 0; i < N; i++)
            {
                string[] pair = Console.ReadLine().Split();
                string site = pair[0];
                string password = pair[1];
                passwords.TryAdd(site, password);
            }

            for (int i = 0; i < M; i++)
            {
                string site = Console.ReadLine();
                Console.WriteLine(passwords[site]);
            }
        }
    }
}
