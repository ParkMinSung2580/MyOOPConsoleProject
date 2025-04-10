using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOOPConsoleProject.GameObjects;
using MyOOPConsoleProject.GameObjects.item;

namespace MyOOPConsoleProject.Scene
{
    public class FirstTown : FieldScene
    {
        public FirstTown()
        {
            Name = "FirstTown";

            mapData = new string[]
            {
                "############",
                "#          #",
                "#          #",
                "#          #",
                "#          #",               
                "############"
            };

            map = new bool[6, 12];

            gameObjects = new List<GameObject>();
            gameObjects.Add(new NPC("헌터", 'H', new Vector2(3, 3)));
            gameObjects.Add(new Place("ForestField",'F',new Vector2(10,4)));
            gameObjects.Add(new Place("FightScene", 'F', new Vector2(2, 2),false,ConsoleColor.Red));
            gameObjects.Add(new Weapon('J', new Vector2(7, 1), "나무검", 10, 5));
            
            //맵 이동 불가 색칠
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }

                foreach (GameObject go in gameObjects)
                {
                    if (go.isTrigger == false)
                    {
                        map[go.position.y, go.position.x] = false;
                    }
                }
            }
        }

        public override void Enter()
        {
            if (Game.prevSceneName == "TitleScene")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            else if(Game.prevSceneName == "ForestField")
            {
                Game.Player.position = new Vector2(10, 4);
            }
            Game.Player.map = this.map;           
        }
    }
}
