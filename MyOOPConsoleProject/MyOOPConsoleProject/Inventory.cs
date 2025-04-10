using MyOOPConsoleProject.GameObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items;

        public List<Item> Items { get { return items; } }

        public Inventory()
        {
            items = new List<Item>();
        }

        public void Add(Item item) 
        { 
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }

        //플레이어가 가지고 있는 아이템
        public void PrintAll()
        {
            Console.WriteLine("내가 가지고 있는 아이템 : ");
            if (items.Count == 0)
            {
                Console.WriteLine("  인벤토리가 비어 있습니다.");
            }
            else
            {
                foreach (Item item in items)
                {
                    Console.WriteLine($"  - {item.Name}");
                }
            }
            Console.WriteLine();
        }
    }
}
