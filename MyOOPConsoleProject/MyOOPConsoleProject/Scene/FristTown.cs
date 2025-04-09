using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOOPConsoleProject.GameObjects;

namespace MyOOPConsoleProject.Scene
{
    public class FirstTown : FieldScene
    {
        public FirstTown()
        {
            Name = "FristTown";

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
            gameObjects.Add(new NPC("행인", 'O', new Vector2(3, 3)));
            gameObjects.Add(new Place("ForestField",'F',new Vector2(10,4)));
            
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
                        map[go.position.x, go.position.y] = false;
                    }
                }
            }
        }

        public override void Enter()
        {
            Game.Player.map = this.map;
            Game.Player.position = new Vector2(1, 1);
        }
    }
}
