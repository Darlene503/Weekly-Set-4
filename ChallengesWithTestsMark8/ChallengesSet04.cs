using System;
using System.Diagnostics;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;  
                }
                else
                {
                    result -= number; 
                }
            }

            return result;
        }


        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = int.MaxValue;

            if (str1.Length < shortestLength)
                shortestLength = str1.Length;

            if (str2.Length < shortestLength)
                shortestLength = str2.Length;

            if (str3.Length < shortestLength)
                shortestLength = str3.Length;

            if (str4.Length < shortestLength)
                shortestLength = str4.Length;

            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = int.MaxValue;

            if (number1 < smallestNumber)
                smallestNumber = number1;

            if (number2 < smallestNumber)
                smallestNumber = number2;

            if (number3 < smallestNumber)
                smallestNumber = number3;

            if (number4 < smallestNumber)
                smallestNumber = number4;

            return smallestNumber;
        }


        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }


        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
                   sideLength1 + sideLength3 > sideLength2 &&
                   sideLength2 + sideLength3 > sideLength1;
        }


        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }


        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
                return false;

            int countNull = 0;
            int countNotNull = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                    countNull++;
                else
                    countNotNull++;
            }

            return countNull > countNotNull;
        }


        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0.0;

            int evenCount = 0;
            int evenSum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                    evenSum += number;
                }
            }

            if (evenCount == 0)
                return 0.0;

            return (double)evenSum / evenCount;
        }

        public int Factorial(int number)
        {
            //if (number == 0)
            //{
            //    return 1;
            //}
            //return number * Factorial(number -1);

            var fact = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for(int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;


        }



    }
}
