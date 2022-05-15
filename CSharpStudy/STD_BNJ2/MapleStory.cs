using System;
using System.Threading;

namespace STD_BNJ2
{
    public class MapleStory
    {
        public void Run()
        {
            // 메이플 실행
            // 직업선택            
            // 뭘 할것인지 ?
            // 던전에 간다
            // 상점에 간다

            // 던전에 가면 ?
            // - 전투를 한다

            // 상점에 가면 ?
            // - 무기, 포션을 살 수 있다.


            // 직업을 나열
            // 전사, 법사, 아처

            // 오늘 절차지향적 게임 개발
            // 다음 객체지향적 게임 개발

            // 유저는 체력, 공격, 속도를 갖고, 직업별로 조금씩 다르다!
            int hp = 10;
            int userAtk = 0;
            int speed = 0;
            string job = "모험가";

            // 턴제 게임
            // 스피드가 빠르면 먼저 공격한다.
            // 공격을 받으면 체력이 공격력 만큼 감소 한다.

            Console.WriteLine("메이플 세계에 오신 것을 환영합니다!");

            Console.WriteLine("직업을 선택해 주세요!");
            Console.WriteLine("1. 전사 \t 2. 법사 \t 3. 아처");
            var select = Console.ReadLine();

            if(select == "1")
            {
                job = "전사";
                Console.WriteLine("전사를 선택하셨습니다!");
                hp = 500;
                userAtk = 100;
                speed = 5;
            }
            else if(select == "2")
            {
                job = "법사";
                Console.WriteLine("법사를 선택하셨습니다!");
                hp = 300;
                userAtk = 120;
                speed = 3;
            }
            else if (select == "3")
            {
                job = "아처";
                Console.WriteLine("아처를 선택하셨습니다!");
                hp = 400;
                userAtk = 80;
                speed = 10;
            }

            // 유저 능력치
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("--- User Status ---");

            Console.WriteLine("직업 : " + job);
            Console.WriteLine("HP : " + hp);
            Console.WriteLine("Atk : " + userAtk);
            Console.WriteLine("Speed : " + speed);


            // 유저의 선택을 제공
            Console.WriteLine();
            Console.WriteLine("무엇을 할것인가요?");

            Console.WriteLine("1. 상점 \t 2. 던전");
            select = Console.ReadLine();

            if (select == "1")
            {
                Console.WriteLine("상점에 진입합니다!");
            }
            else if(select == "2")
            {
                Console.WriteLine("던전에 진입합니다!");
            }
        }
    }
}