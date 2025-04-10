using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject.Scene
{
    public class TitleScene : BaseScene
    {
        public TitleScene() { Name = "TitleScene"; }
        
        public override void Render()
        {
            Console.WriteLine("============================");
            Console.WriteLine("=                          =");
            Console.WriteLine("=                          =");
            Console.WriteLine("=          MYRPG           =");
            Console.WriteLine("=                          =");
            Console.WriteLine("=                          =");
            Console.WriteLine("============================");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르세요...");
        }

        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            Game.ChangeScene("FirstTown");
        }

        public override void Exit()
        {
            Game.prevSceneName = this.Name;
        }
    }
}
