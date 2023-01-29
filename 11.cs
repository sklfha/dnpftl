using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccccccccc
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello orld");
            System.Console.WriteLine("내 이름은 000입니다.");
            System.Console.WriteLine("나는 sbs 게임 아카데미 학생입니다.");
            System.Console.WriteLine("나는 00살입니다");
            System.Console.WriteLine("나는 현재 남동구에 살고 있습니다");
            System.Console.WriteLine("지금 현재 집에 가고 싶습니다.");
            System.Console.WriteLine("지금 현재 졸립니다.");

            System.Console.WriteLine("dlrjs WriteLine");

            //writeLine tkdydqjq
            System.Console.WriteLine("1");
            System.Console.WriteLine("2");
            System.Console.WriteLine("3");
            System.Console.WriteLine("4");
            System.Console.WriteLine("5");
            System.Console.WriteLine("6");
            System.Console.WriteLine("7");
            System.Console.WriteLine("8");
            System.Console.WriteLine("9");
            System.Console.WriteLine("10");

            //데이버 형 - string
            string myName;
            string myAhge;

            myName = "ㅁㅁㅁ";
            myAhge = "나는 ㅁㅁㅁ입니다.";

            System.Console.WriteLine(myName);
            System.Console.WriteLine(myAhge);

            //ReadLine();

            string MyName;

            System.Console.WriteLine("이름을 입력해주세요: ");
            MyName = System.Console.ReadLine();

            System.Console.Write("당신의 이름은 : ");
            System.Console.WriteLine(MyName);

            System.Console.WriteLine("이름 : ㅁㅁㅁ");
            System.Console.WriteLine("주소 : 부평구 7번 출구 ");
            System.Console.WriteLine("나이 : 00");
            System.Console.WriteLine("성별 : 여자");

            System.Console.WriteLine("당신의 이름은  {MyName} 이고. 당신의 나이는 {MyAhge} 입니다. ");
            System.Console.WriteLine("ekdtlsdml dlfmadms {0}이고, 당신의 나이는 {1} 입니다., MyName, MyAhge");


            string myAge;
            System.Console.WriteLine("태어난 년도를 입력해주세요 : ");
            myAge = System.Console.ReadLine();

            int myAgeNumber = Convert.ToInt32(myAge);
            string nowAge = (2023 - myAgeNumber).ToString();

            System.Console.Write(nowAge);

            //1. 변수형 종류 주석으로 작성 후 , 각 변수형들의 최대값 최소값 출력하기
            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            //2.syring으로이름나이 입력 받고, 출력하기
            //나이는출생년도만 입력받기
            System.Console.WriteLine("");

            System.Console.Write("당신의 이름은 :  ");
            MyName = System.Console.ReadLine();
            System.Console.WriteLine(MyName);

            System.Console.Write("당신의 태어난 년도는 :  ");
            myAge = System.Console.ReadLine();
            System.Console.WriteLine(myAge);

            int myAgeNumber2 = Convert.ToInt32(myAge);
            int nnnn = 2023 - myAgeNumber2;

            System.Console.WriteLine($"당신의 이름은 {MyName}");

            System.Console.WriteLine($"당신의 나이는 {nnnn}");


            //3.@사용 해서 별 그리기
            System.Console.WriteLine(@"
                    @
                   @@@
                  @@@@@
                 @@@@@@@@
         @@@@@@@@@@@@@@@@@@@@@@@@
           @@@@@@@@@@@@@@@@@@@@
            

");


            //4.int값을 float로 캐스팅하기
            //   3.12를 int값으로 캐스팅하기

            int k = 3;
            float fll = (float)k;

            float f22 = (3.12f);
            int f33 = Convert.ToInt32(f22);

            System.Console.WriteLine(f33);


            int[] k111 = new int[3];

            int[] kkk = new int[4] { 1, 2, 3, 4, };
            string[] lang = new string[3] { "c#", "c++", "c" };
            long[] lolo = new long[1] { 2 };

            System.Console.WriteLine(kkk[0]);

            //kkk -> 89.6.456.4
            //lang -> c#,c++.c

            //int형 배열 5칸짜리 5개
            //string 형 배열 5칸짜리 5개 만들기


            int[] kkk1 = new int[4] { 89, 6, 456, 4 };
            string[] lang1 = new string[3] { "c#", "c++", "c" };


            int[] LaterArray;
            System.Console.WriteLine("배열의 크기는 ?");
            string srraysize;
            srraysize = System.Console.ReadLine();

            LaterArray = new int[Convert.ToInt32(srraysize)];

            string[] _lang = new string[3];
            _lang[0] = "c";
            _lang[1] = "c++";
            _lang[2] = "c#";

            System.Console.WriteLine($"0번 값은 {_lang}");

                //식당에 음식이 떡볶이 , 김밥, 라면 , 라뽁이가 있다.
                // 이중에 숫자를 입력 받으면 입력 받은 값은 비어있게 된다.

            // 비어있게 되었다는 결과값도 출력하라
            string[] Food = new string[4];
            Food[0] = "떡볶이";
            Food[1] = " 김밥";
            Food[2] = " 라면";
            Food[3] = " 라뽁이";
            System.Console.WriteLine($"1번 값은 {Food[0]}");
            System.Console.WriteLine($"2번 값은 {Food}");
            System.Console.WriteLine($"3번 값은 {Food}");
            System.Console.WriteLine($"4번 값은 {Food}");

            string a = new int[Convert.ToInt32(Food)];

            System.Console.WriteLine($"선택된 음식은 {Food[a]}입니다.");


        }
    }

}
