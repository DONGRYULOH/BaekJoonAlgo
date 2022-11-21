using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     1. 자기점수중 최댓값(M)
     2. 모든 점수를 점수/M * 100 수정 
 */
namespace Basic
{
    internal class BaekJoon1546
    {

        static void Main(string[] args)
        {
            // 입력
            // 1. 과목의 개수(N) 1000보다 작거나 같음
            int subjectNumber = int.Parse(Console.ReadLine());

            // 2. 과목성적은 100보다 작거나 같은 음이아닌 정수이고 적어도 하나의 성적은 0보다 크다.
            String[] subjectGradeSplit = Console.ReadLine().Split(' ');
            int[] subjectGradeArray = new int[subjectNumber];
            int subjectGradeCount = 0;
            int subjectNotZeroCount = 0;

            while (subjectGradeCount < subjectNumber)
            {
                int subjectGrade = int.Parse(subjectGradeSplit[subjectGradeCount]);
                if (subjectGrade >= 0 && subjectGrade <= 100)
                {
                    subjectGradeArray[subjectGradeCount] = subjectGrade;
                    subjectGradeCount++;
                    if (subjectGrade != 0)
                    {
                        subjectNotZeroCount++;
                    }
                }
                else
                {
                    Console.WriteLine("과목성적은 0이상 100이하인 정수만 입력가능합니다. 과목성적을 다시 입력해주세요");
                    subjectGradeSplit = Console.ReadLine().Split(' ');
                    subjectGradeCount = 0;
                    subjectNotZeroCount = 0;
                }

                // 마지막 과목성적입력시 모든 과목성적중에 0보다 큰 성적이 하나라도 없다면 다시입력
                if (subjectGradeCount == subjectNumber && subjectNotZeroCount == 0)
                {
                    Console.WriteLine("적어도 하나의 과목성적은 0보다 큰값이 있어야 합니다. 과목성적을 다시 입력해주세요");
                    subjectGradeSplit = Console.ReadLine().Split(' ');
                    subjectGradeCount = 0;
                    subjectNotZeroCount = 0;
                }
            }

            // 로직
            // 1. 가장높은 성적구하기
            double subjectAvg = 0;
            int subjectMaxGrade = subjectGradeArray[0];
            for(int i=1; i< subjectGradeArray.Length; i++)
            {
                if (subjectGradeArray[i] > subjectMaxGrade) {
                    subjectMaxGrade = subjectGradeArray[i];
                }
            }

            // 2. 모든성적을 가장높은성적으로 계산
            for (int i = 0; i < subjectGradeArray.Length; i++)
            {
                subjectGradeArray[i] = subjectGradeArray[i] / subjectMaxGrade * 100;
            }

            for (int i = 0; i < subjectGradeArray.Length; i++)
            {
                subjectAvg += subjectGradeArray[i];
            }
            Console.WriteLine(subjectAvg);
            subjectAvg = subjectAvg / subjectNumber;
            Console.WriteLine(subjectAvg);


        }
    }
}
