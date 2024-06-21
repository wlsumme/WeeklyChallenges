using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (var i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];

                }
            }
            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sent = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sent += word.Trim() + " ";
                }
            }
            if (sent.Length == 0)
            {
                return "";
                ;
            }

            sent = sent.Trim();
            sent += ".";
            return sent;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {

            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> sol = new List<double>();

            for (var i = 3; i < elements.Count; i += 4)
            {
                sol.Add(elements[i]);

            }
            return sol.ToArray();


        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;


        }
    }
}
