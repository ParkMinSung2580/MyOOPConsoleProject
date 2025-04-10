using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject
{
    public class Player
    {
        public string name;
        public string Name { get { return name; } set { name = value; } }
        public Vector2 position;
        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }
        public bool[,] map;

        private int hP;
        public int HP { get { return hP; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            hP = maxHP;
        }

        public void Heal(int amount)
        {
            hP += amount;
            if(hP > maxHP)
            {
                hP = maxHP;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
                //case ConsoleKey.I:
                    //inventory.Open();
                    //break;
            }
        }

        //Player 움직이기
        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
    }
}
