using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject
{
    //인터페이스 함수 플레이가 GameObject랑 상호작용할때 처리
    //구현은 상호작용 대상 객체
    //1.문제점 Place 객체와 플레이어가 위치가 같아야지만 interact을 수행중인데
    // NPC클래스의 객체와 플레이어와 충돌을 하지 않게 설정했는데 상호작용을 못함 
    // 이를 해결하기 위해서 상호작용 인터페이스를 여러가지 형태로 나눌필요가 있음
    // ex)플레이어와 게임오브젝트가 겹치면 충돌기반 상호작용 <-> 플레이어가 npc의 일정거리 안에 존재하여 명령키를 입력할경우 상호작용


    // 기본 상호작용 인터페이스
    public interface IInteractable
    {
        void Interact(Player player);
    }

    // 충돌 기반 상호작용
    public interface ICollidable
    {
        void OnCollision(Player player);
    }

    // 명령 기반 상호작용
    public interface ICommandInteractable
    {
        void OnCommand(Player player);
        //bool IsInRange(Vector2 playerPos);
    }

}
