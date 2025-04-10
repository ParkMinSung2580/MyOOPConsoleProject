using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOOPConsoleProject;

namespace MyOOPConsoleProject.GameObjects
{
    public abstract class Item : GameObject, ICollidable
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        //protected string description;

        public Item(char symbol, Vector2 position ,string name)
            : base(ConsoleColor.Yellow, symbol, position, true, true) { this.name = name; }

        public void OnCollision(Player player)
        {
             player.Inventory.Add(this);
        }

        //public abstract void Use();
    }
}
