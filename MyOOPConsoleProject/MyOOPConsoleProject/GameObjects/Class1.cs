using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject.GameObjects
{
    public class Item : GameObject, ICommandInteractable
    {
        public string name;
        public string description;

        public Item(char symbol, Vector2 position)
            : base(ConsoleColor.Yellow, symbol, position, true, false)
        {

        }

        public void OnCommand(Player player)
        {
            if (IsInRange(player.position))
            {
                player.Inventory.Add(this);
            }
        }

        //public abstract void Use();
    }
}
