using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject
{
    public abstract class GameObject //: IInteractable
    {
        public ConsoleColor color;
        public char symbol;
        public Vector2 position;
        public bool isOnce;
        public bool isTrigger;

        //Trigger변수추가함으로 플레이어가 게임오브젝트를 통과하게 할지 안하게 할지
        public GameObject(ConsoleColor color, char symbol, Vector2 position, bool isOnce,bool isTrigger = true)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
            this.isOnce = isOnce;
            this.isTrigger = isTrigger;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public bool IsInRange(Vector2 playerPos)
        {
            int dx = Math.Abs(playerPos.x - position.x);
            int dy = Math.Abs(playerPos.y - position.y);

            //대각선안되게 x,y좌표 합쳐서 1만 가능
            return (dx + dy == 1);
        }
        //public abstract void Interact(Player player);
    }
}
