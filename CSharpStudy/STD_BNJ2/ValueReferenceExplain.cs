using System;

namespace STD_BNJ2
{
    public class ValueReferenceExplain
    {
        // strcut는 값 형식

        public struct Dog
        {
            public int a;
            public int b;
        }

        public class TestDog
        {

        }

        public void Explain()
        {
            // 값형식과 참조형식의 설명
            // '복사' 가 일어나냐 안 일어 나냐
            // class 는 참조형식
            // 대입 연산으로는 메모리가 할당이 잃어나지 않는다.


            // class 생성 new 메모리 할당
            // 같은 참조를 하고 있다.
            TestDog tdog = new TestDog();
            TestDog chiwawa2 = tdog;

            Dog dog = new Dog(); // 메모리에 할당한다.
            dog.a = 5;
            dog.b = 10;

            dog.a = 8;

            // struct
            // 복사
            // dog의 "값" 들을 chiwawa에 "넣는다", "값" 만 복사를 한다.
            Dog chiwawa = dog; // 치와와에 도그를 넣음 , dog.a == 5, dog.b == 10

            // struct , class

            dog.a = 20;

            Console.WriteLine("chiwawa " + chiwawa.a); // chiwawa의 a는 5
            // 컴파일 타임은 코드를 짜고 난 뒤에 실행 전에 
            // 런타임은 - 코드가 완전히 실행 될 때
        }
    }
}