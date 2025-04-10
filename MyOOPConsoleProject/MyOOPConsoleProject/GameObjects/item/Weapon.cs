using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject.GameObjects.item
{
    public class Weapon :Item
    {
        private int ackPoint;
        private int durability;

        public int AckPoints { get { return ackPoint; } set { ackPoint = value; } }
        public int Durability { get { return durability; } set { durability = value; } } 

        public Weapon(char symbol, Vector2 position, string name, int ackPoint,int durability)
            : base(symbol,position,name) 
        {
            color = ConsoleColor.Gray;
            this.ackPoint = ackPoint;
            this.durability = durability;
        }

        public void Attack(int ackPoint)
        {
            durability--;
            //TODO - 공격 로직 구현
        }
    }

    //웨폰 빌더
    public class WeaponBuilder
    {
        private char symbol = 'W';
        private Vector2 position = new Vector2(0, 0);
        private string name = "알 수 없는 무기";
        private int ackPoint = -1;
        private int durability = -1;

        public WeaponBuilder SetSymbol(char symbol)
        {
            this.symbol = symbol;
            return this;
        }

        public WeaponBuilder SetPosition(Vector2 position)
        {
            this.position = position;
            return this;
        }

        public WeaponBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public WeaponBuilder SetAttackPoints(int attackPoints)
        {
            this.ackPoint = attackPoints;
            return this;
        }

        public WeaponBuilder SetDurability(int durability)
        {
            this.durability = durability;
            return this;
        }

        public Weapon Build()
        {
            return new Weapon(symbol, position, name, ackPoint, durability);
        }

        // 사전 정의된 무기 유형을 생성하는 팩토리
        public class WeaponFactory
        {
            //private Dictionary<string, Func<Vector2>, Weapon>
        }
    }
}
