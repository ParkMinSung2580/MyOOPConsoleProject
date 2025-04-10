using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject.GameObjects
{

    public class NPC : GameObject, ICommandInteractable
    {
        private string name;
        //private string message;
        private int interactionRange = 1;

        public string Name { get { return name; } }
        public int InteractionRange { get { return interactionRange; } }

        public NPC(string npcName, char symbol, Vector2 position)
            : base(ConsoleColor.White, symbol, position,false,false)
        {
            this.name = npcName;
        }
        public void OnCommand(Player player)
        {
            //  TODO - 상호작용시 대화하는 기능 추가
            if (IsInRange(player.position))
            {
                // Console.WriteLine($"{player.Name} interacts with {this.Name}."); // 처음 디버깅용
                
                int currentCursorLeft = Console.CursorLeft;
                int currentCursorTop = Console.CursorTop;

            //대화를 위해 커서를 맵 아래로 이동
                //2차원은 GetLength(0)은 행의 개수, Getlength(1)은 열의 개수를 알 수 있습니다.
                //출처: https://coding-abc.kr/74 [coding-abc.kr:티스토리]
                //Console.SetCursorPosition(0, player.map.GetLength(0) + 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{name}: 안녕하세요! 저는 {name}입니다.");
                Console.ResetColor();
                //Console.WriteLine(isTrigger);             //디버깅
                Console.ReadKey(true);

                //선택사항: 대화 영역 지우기
                //Console.SetCursorPosition(0, player.map.GetLength(0) + 2);
                //Console.WriteLine(new string(' ', Console.WindowWidth));
                //Console.WriteLine(new string(' ', Console.WindowWidth));

                //커서 위치 복원
                Console.SetCursorPosition(currentCursorLeft, currentCursorTop);
            }
        }
    }
}
