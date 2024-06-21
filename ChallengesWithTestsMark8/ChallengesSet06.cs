using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
            {
                return false;
            }

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (var w in words)
            {
                if (string.Equals(w, word, comparison))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            
            
                if (num <= 1)
                {
                    return false;
                }
                if (num == 2 || num == 3)
                {
                    return true;
                }
                if (num % 2 == 0 || num % 3 == 0)
                {
                    return false;
                }

                for (int i = 5; i * i <= num; i += 6)
                {
                    if (num % i == 0 || num % (i + 2) == 0)
                    {
                        return false;
                    }
                }

                return true;
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int lastUniqueIndex = -1;

            for (int i = 0; i < str.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    lastUniqueIndex = i;
                }
            }

            return lastUniqueIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthDoub = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthDoub.ToArray();
            }

            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthDoub.Add(elements[i]);
            }

            return nthDoub.ToArray();
        }
    }
}
