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

        public Inventory()
        {
            items = new List<Item>();
        }

        public void Add(Item item) 
        { 
            items.Add(item);
        }
    }
}
