using MyOOPConsoleProject.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;

        private static BaseScene curScene;
        public static string prevSceneName;

        private static Player player;
        public static Player Player { get { return player; } }

        private static bool gameOver;

        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
            }

            End();
        }

        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.Name;

            //현재씬 나갈때 Exit()호출
            curScene.Exit();
            curScene = sceneDic[sceneName];
            //새로운씬 들어올 때 Exit()호출
            curScene.Enter();
        }

        /// <summary>
        /// 게임의 시작 작업 진행
        /// </summary>
        private static void Start()
        {
            Console.CursorVisible = false;

            // 게임 설정
            gameOver = false;

            // 플레이어 설정
            player = new Player();

            // 씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            curScene = sceneDic["Title"];

            sceneDic.Add("FirstTown", new FirstTown());
            sceneDic.Add("ForestField", new ForestField());
            sceneDic.Add("FightScene", new FightScene());
        }

        /// 게임의 마무리 작업 진행
        private static void End()
        {

        }
    }
}
