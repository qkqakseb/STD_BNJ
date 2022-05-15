using System;
using System.Collections.Generic;
using System.Linq;

namespace STD_BNJ2
{
    public class Solution
    {
       
    }

    // 서든
    // 래드 팀 또는 블루 팀의 평균 레벨
    // 매칭시스템 개선

    public class MatchingSystem
    {
        public class MatchingResult
        {
            public List<User> redTeam = new List<User>();
            public List<User> blueTeam = new List<User>();
        }

        // 데이터, 기능을 갖고있음.
        // 매칭을 하기 위해 필요한 데이터,
        public MatchingResult Match(User[] inUsers)
        {
            MatchingResult result = new MatchingResult();
            int eachTeamCount = (int)(inUsers.Length * 0.5f + 1); // 10 => 6

            List<User> userList = new List<User>();
            userList.AddRange(inUsers);

            userList.Sort(CompareScore);

            // 로직 여기서 부터
            // 프로그래머가 하는 일

            // 기획자가 하는일 -> 방식으로
            // 기획자는 룰을 정해줌
            // Score 제일높은 사람은, 제일 낮은 사람이랑 팀 되게 해주세요.

            // 배열 
            // 20 30 40 10 50 25

            // 제일 높은 사람 = 50, 40, 30
            // 제일 낮은 사람 = 10, 20, 25

            // 정렬
            // Sort
            //      10, 20, 25, 30, 40, 50
            //배열    0,  1,  2,  3,  4,  5

            // (50, 10)  , (40, 20),  (30, 25)
            //  (5, 0)      (4, 1)     (3,2)

            // 이렇게 팀을 시켜 줘야 겠다.
            // 이걸 코드로!

            // -----

            // 1. 정렬한다.
            // 2. 인덱스 별로 매칭을 한다.

            // 10명이라서 
            int index1 = userList.Count - 1;
            int index2 = 0;
            bool isBlueTeam = false; // 번갈아 가면서 들어올 수 있도록
            for(int i = 0; i < eachTeamCount; ++i)
            {
                if (index1 <= index2)
                    break;

                var bestScroeUser = userList[index1];
                var lowScoreUser = userList[index2];
                if (isBlueTeam) // true
                {
                    result.blueTeam.Add(bestScroeUser);
                    result.blueTeam.Add(lowScoreUser);
                    isBlueTeam = false; // false
                }
                else // false
                {
                    result.redTeam.Add(bestScroeUser);
                    result.redTeam.Add(lowScoreUser);
                    isBlueTeam = true; // true
                }
                index1--; // 9
                index2++; // 0
            }
            return result;
        }

        // -1 0 1
        private int CompareScore(User x, User y)
        {
            if (x.Score > y.Score)
                return -1;
            else if(x.Score == y.Score)
                return 0;

            return 1;
        }
    }

    public class User
    {
        public enum Team
        {
            Red,
            Blue,
        }
        public int Score;
        public Team team;
    }

    public class Human
    {
        // 데이터,
        int age;
        float height;
        int iq;
        int sex;
        public string name;

        // 기능
        public void Eat()
        {
            Console.WriteLine("먹는다!");
        }

        public void Sleep()
        {
            Console.WriteLine("잔다!");
        }

        public void Hello()
        {
            Console.WriteLine("My Name Is " + name);
            Console.WriteLine("how are you!?");
        }
    }
    

    // test case 방식
    class Program
    {
        // 요청 : 평균키를 구하는 프로그램을 만들어 주세요.
        // 함수

        static public double GetAvgHeigh()
        {
            return 10;
        }

        static void Main(string[] args)
        {
            // 값 참조 설명
            //ValueReferenceExplain a = new ValueReferenceExplain();
            //a.Explain();


            User[] users = new User[12];
            for(int i = 0; i< users.Length; ++i)
            {
                users[i] = new User();
                users[i].Score = (i * 5);
                users[i].team = User.Team.Red;

                if (i >= 5)
                    users[i].team = User.Team.Blue;
            }


            MatchingSystem matchingSystem = new MatchingSystem();
            var result = matchingSystem.Match(users);

            foreach(var user in result.blueTeam)
            {
                Console.WriteLine("blue team : " + user.Score);
            }

            foreach (var user in result.redTeam)
            {
                Console.WriteLine("red team : " + user.Score);
            }
        }
    }
}
