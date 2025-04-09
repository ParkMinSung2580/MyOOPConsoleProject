using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MyOOPConsoleProject;

namespace MyOOPConsoleProject.Scene
{
    //필드를 팩토리 빌더 ? 사용X
    //필드맵 - 다양한 맵들의 부모클래스
    public abstract class FieldScene : BaseScene
    {
        //키 인풋
        private ConsoleKey input;

        //자식에게 물려줄 mapData및 map이동 bool값
        protected string[] mapData;
        protected bool[,] map;

        protected List<GameObject> gameObjects;

        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }

            Game.Player.Print();

            Console.SetCursorPosition(0, map.GetLength(0) * 2);
            //Game.Player.inventory.PrintAll();
        }

        //플레이어 인풋 확인
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        //플레이어 이동
        public override void Update()
        {
            Game.Player.Move(input);

            if (input == ConsoleKey.R)
            {
                foreach (GameObject go in gameObjects)
                {
                    if (go is ICommandInteractable commandInteractable)
                    {
                        commandInteractable.OnCommand(Game.Player);
                    }
                }
            }
        }

        public override void Result()
        {
            /*foreach (GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position)
                {
                    go.Interact(Game.Player);
                    if (go.isOnce == true)
                    {
                        gameObjects.Remove(go);
                    }
                    break;
                }
            }*/
            foreach (GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position && go is ICollidable collidable)
                {
                    collidable.OnCollision(Game.Player);
                    if (go.isOnce)
                    {
                        gameObjects.Remove(go);
                        break;
                    }
                }
            }
        }

        //자식에게서 설정된 mapdata를 가지고 맵을 그림
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
                for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
