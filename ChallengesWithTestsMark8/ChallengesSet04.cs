using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;

            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
                return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {



            var minLength = str1.Length;

            if(minLength > str2.Length)
            {
                minLength = str2.Length;
            }
            if(minLength > str3.Length)
            {
                minLength = str3.Length;
            }
            if (minLength > str4.Length)
            {
                minLength = str4.Length;
            }
            return minLength;
            
            
            
            //return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));
            //    if(str1.Length < str2.Length && str1.Length < str3.Length && str1.Length < str4.Length)
            //    {
            //        return str1.Length;
            //    }
            //    else if (str2.Length < str1.Length && str2.Length < str3.Length && str2.Length < str4.Length)
            //    {
            //        return str2.Length;
            //    }
            //    else if (str3.Length < str1.Length && str3.Length < str2.Length && str3.Length < str4.Length)
            //    {
            //        return str3.Length;
            //    }
            //    else
            //    {
            //        return str4.Length;
            //    }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallestNum = number1;
            if(smallestNum > number2)
            {
                smallestNum = number2;
            } 
            if(smallestNum > number3)
            {
                smallestNum = number3;
            }
            if (smallestNum > number4)
            {
                smallestNum = number4;
            }
            return smallestNum;
            
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && 
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength1 + sideLength3 > sideLength3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            if(input == null)
            {
                return false;
            }
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if(objs == null || objs.Length == 0)
            {
                return false;
            }
            var nullCount = 0;
            
            foreach(var obj in objs)
            {
                if(obj == null)
                {
                    nullCount++;
                }

            }
            var elem = objs.Length / 2;
            if(nullCount > elem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double evenAmount = 0;
            double evenNumber = 0;

            foreach(var number in numbers)
            {
                if(number % 2 == 0)
                {
                    evenAmount += number;
                    evenNumber++;

                }

            }
            if(evenAmount == 0)
            {
                return 0;
            }
            return evenAmount / evenNumber;

        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException("Factorial is not defined for negative numbers.");

            }

            var fact = 1;

            for(var i = 1; i<= number; i++)
            {
                fact *= i;
            }
            return fact;

        }
    }
}
