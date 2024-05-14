using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return true;
            }
            else if (c >= 'A' && c <= 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
           

        }

        public bool CharacterIsNotLetter(char c) 
        {
            if (c >= 'a' && c <= 'z')
            {
                return false;
            }
            else if (c >= 'A' && c <= 'Z')
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var numEls = vals.Length;
            if (numEls % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            var min = numbers.Min();
            var max = numbers.Max();
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var strOneLength = str1.Length;
            var strTwoLength = str2.Length;

            if(strOneLength < strTwoLength)
            {
                return strOneLength;
            }
            else
            {
                return strTwoLength;
            }

        }











        public int Sum(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            else
            {
                var sumSum = numbers.Sum();
                return sumSum;
            }

        }










        public int SumEvens(int[] numbers)
        {
            if(numbers == null || !numbers.Any())
            {
                return 0;
            }
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
               
            }
                return sum;
                
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null || !numbers.Any())
            {
                return false;
            }
            
            var sum = numbers.Sum();
            if(sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;

            for(int i = 1; i < number; i += 2)
            {
                count++;
            }
            return count;

        }
    }
}
