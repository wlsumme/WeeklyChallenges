using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if(val == false)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {

            return false; 
            }
            var oddNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if(number % 2 != 0)
                {
                    oddNumbers.Add(number);
                }
            }
            if(oddNumbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasNumber = password.Any(char.IsDigit);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);

            if (hasNumber == true && hasUpper == true && hasLower == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        public char GetFirstLetterOfString(string val)
        {
            char firstLet = val.FirstOrDefault();
            return firstLet;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLet = val[val.Length - 1];
            return lastLet;
        }

        public decimal Divide(decimal dividend, decimal divisor)

        {
            if(dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else
            {
            return dividend / divisor;

            }
                
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = nums[nums.Length - 1];
            int first = nums[0];
            return last - first;      
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 0; i < 100; i++)
            { 
                if(i % 2 != 0)
                {
                    odds.Add(i);
                }
                    

            }
                return odds.ToArray();
            
         }   
            
            
            
            
            // I Couldnt get this to word and it made me sad
            //for(int i = 99; i >= 0; i -= 2)
            //{
            //    odds.Add(i);
            //}
            //return odds.ToArray();
        

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i]= words[i].ToUpper();
            }
            
        }
    }
}
