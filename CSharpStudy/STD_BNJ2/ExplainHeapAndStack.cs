namespace STD_BNJ2
{
    public class ExplainStackClass
    {
        public int a;
        public int b;
        public int c;
    }

    public struct ExplainStackStruct
    {

        public int a;
        public int b;
        public int c;
    }

    public class ExplainHeapAndStack
    {

        public void OnFunction(int index)
        {
            // 함수 호출
            // index : 스택에 저장

            // 지역변수들 : 스택에 저장
            int sA;
            int sB;
            int sC;

            // 생성, 가르키는자
            ExplainStackClass classA;

            // 생성, 값 - 구조체는 값을 의미,
            ExplainStackStruct structB = new ExplainStackStruct();

            // classA라는 변수는 스택
            // new 힙에 저장됨?
            // classA는 그럼 힙이야? 스택이야?
        }

        public void OtherFunction()
        {

        }
    }
}