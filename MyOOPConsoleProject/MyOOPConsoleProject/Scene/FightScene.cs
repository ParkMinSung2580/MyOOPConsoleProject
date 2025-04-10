using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject.Scene
{
    public class FightScene : BaseScene
    {
        private ConsoleKey input;
        /*
            curScene.Render();
            curScene.Input();
            curScene.Update();
            curScene.Result();
        */
        public override void Render()
        {
            Console.WriteLine("전투씬에 돌입합니다.");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Result()
        {
            Console.WriteLine("결과를 표출합니다");
            Console.WriteLine("전투에 승리하셨습니다, 이전씬으로 돌아갑니다");
            // TODO - 이전씬으로 되돌아가기 구현
            Console.ReadKey(true);
            Game.ChangeScene("FirstTown");
        }

        public override void Update()
        {
            Console.WriteLine("당신이 누른키는 {0} 입니다",input);
        }

        public override void Enter() { Console.WriteLine("."); }
        public override void Exit() { Console.WriteLine("."); }
    }
}
