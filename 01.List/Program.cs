using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _01.List.ListProgram;

namespace _01.List
{
    internal class Program
    {
        /*
         * <실습>

            1. 사용자에게 숫자를 입력 받아서
                - 0부터 숫자까지 가지는 리스트 만들기
                - 0 요소를 제거
                - 리스트가 가지는 모든 요소들을 출력해주는 반복문 작성

            //////////////	/////////////////////////////////

            2. 사용자의 입력을 받아서 없는 데이터면 추가, 있던 데이터면 삭제하는 보관함
                - ex) 1, 6, 7, 8, 3 들고 있던 상황이면
                - 2 입력하면 없던 경우니까 1, 6, 7, 8, 3, 2
                - 7 입력하면 있던 경우니까 1, 6, 8, 3

            ///////////////////////////////////////////////

             A++) 인벤토리 구현 (아이템 수집, 아이템 버리기)

         */

        public static void Main() {
            // 1.
            Console.Write("숫자를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());
            SpecialList list = new SpecialList(input);
            list.PrintList();

            // 2.
            Console.Write("추가하거나 제거할 숫자를 입력하세요: ");
            int input1 = int.Parse(Console.ReadLine());
            list.AddOrDelete(input1);
            list.PrintList();

            Console.Write("추가하거나 제거할 숫자를 입력하세요: ");
            int input2 = int.Parse(Console.ReadLine());
            list.AddOrDelete(input2);
            list.PrintList();

            // A++
            Inventory inventory = new Inventory();
            //아이템 추가
            Item shield = new Item("방패");
            inventory.AddItem(shield);
            inventory.ShowItems();

            //아이템 다수 추가
            Item potion = new Item("물약");
            Item sword = new Item("검");
            Item bread = new Item("빵");
            inventory.AddItem(potion, sword, bread);
            inventory.ShowItems();

            //아이템 제거
            inventory.RemoveItem(sword);
            inventory.ShowItems();

            //인벤토리 비움
            inventory.ClearInventory();
            inventory.ShowItems();
        }
    }
}
