using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.List
{
    public class Inventory
    {
        List<Item> inventory;
        public Inventory() { inventory = new List<Item>(); }
        public void AddItem(Item item)
        {
            Console.WriteLine($"{item.Name}을 얻었습니다.");
            inventory.Add(item);
        }
        public void AddItem(params Item[] items) { 
            foreach(var item in items)
            {
                AddItem(item);
            }
        }
        public void RemoveItem(Item item) 
        {
            Console.WriteLine($"{item.Name}을 버렸습니다.");
            inventory.Remove(item);
        }
        public void ClearInventory() 
        {
            Console.WriteLine("인벤토리를 비웠습니다.");
            inventory.Clear(); 
        }
        public void ShowItems()
        {
            Console.Write("인벤토리: ");
            foreach (Item item in inventory)
            {
                Console.Write($"[ {item.Name} ]");
            }
            Console.WriteLine();
        }
    }
    public class Item
    {
        string name;
        public string Name { get { return name; } }

        public Item(string name)
        {
            this.name = name;
        }
    }
}
