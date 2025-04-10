using MyOOPConsoleProject.GameObjects;
using MyOOPConsoleProject.GameObjects.item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject.Scene
{
    public class ForestField : FieldScene
    {

        public ForestField()
        {
            Name = "ForestField";

            mapData = new string[]
            {
                "############",
                "#        # #",
                "#    #     #",
                "#      #   #",
                "#  # #     #",
                "############"
            };

            map = new bool[6, 12];

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FirstTown", 'F', new Vector2(1, 1),true));
            gameObjects.Add(new Weapon('J', new Vector2(3, 1), "철검", 20, 5));

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
            Game.Player.map = this.map;
            if(Game.prevSceneName ==  "FirstTown")
                Game.Player.position = new Vector2(1, 1);
            /*else
                Game.Player.position = new Vector2(1, 1);*/
        }

        public override void Exit()
        {
            Game.Player.position = new Vector2(1, 1);
        }
    }
}
