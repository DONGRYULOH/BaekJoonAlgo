using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void numberSum(String number) {
            // 입력받은 문자열을 char 배열로 변환하기 
            /*
                공백없이 12345 이런식으로 정수자료형에 들어가면 숫자를 하나씩 분리할 방법이 없음
            */
            char[] cNum = number.ToCharArray();

            /*
                문자를 숫자로 변환할 경우에는 아스키 코드에 의해서 숫자로 변환이 됨
                문자 0 -> 정수 48 
                문자 1 -> 정수 49
             */
            int sum = 0;
            for (int i = 0; i < cNum.Length; i++)
            {
                sum += (int)cNum[i] - '0';
            }

            Console.WriteLine(sum);
        }

        /*static void Main(string[] args)
        {
            
            *//*
                   정수, 실수와 같은 값타입은 null(값이 할당되지 않은 상태)를 가질 수 없음 
                   1. null이 할당되면 예외처리를 한다. 
                   2. 값타입에 null을 할당할 수 있는 Nullable 타입을 사용한다. 
             *//*
            try {
                int N = int.Parse(Console.ReadLine());
                // 공백없이 주어진 N개의 숫자
                String sNum = Console.ReadLine();
                Program.numberSum(sNum);
            }
            catch(Exception e){ 
                // null -> 정수로 변환하는 경우 예외처리
                Console.WriteLine(e.Message);
            }


        }*/
    }
}
