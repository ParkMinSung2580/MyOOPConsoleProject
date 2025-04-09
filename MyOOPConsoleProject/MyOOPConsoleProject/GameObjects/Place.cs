using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject.GameObjects
{
    public class Place : GameObject, ICollidable
    {
        private string sceneName;

        public Place(string sceneName, char symbol, Vector2 position) :
            base(ConsoleColor.Green, symbol, position, false)
        {
            this.sceneName = sceneName;
        }
        //지정 컬러 생성자
        public Place(string sceneName, char symbol, Vector2 position,ConsoleColor Color) :
            base(ConsoleColor.Red, symbol, position, false)
        {
            this.sceneName = sceneName;
            this.color = Color;
        }

        //플레이어가 해당 Place symbol과 상호작용시 해당 씬으로 변경
        public void OnCollision(Player player)
        {
            Game.ChangeScene(sceneName);
        }
    }
}
