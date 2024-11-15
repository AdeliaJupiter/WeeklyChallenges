using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals == null || vals.Length == 0)
            {
                return false;
            }

            foreach(var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return false;
            }

            foreach (var num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            foreach (var letter in password)
            {
                if(char.IsUpper(letter)) 
                { 
                    hasUpper = true;
                }
                if(char.IsLower(letter))
                {
                    hasLower = true;
                }
                if(char.IsNumber(letter))
                {
                    hasNumber = true;
                }
            }
            if(hasUpper && hasLower && hasNumber)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }
        
        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result = 0;
            if (divisor != 0)
            {
                result = dividend / divisor;
            }
            return result;
        }

        public int LastMinusFirst(int[] nums)
        {
            return ((nums[nums.Length - 1]) - nums[0]);
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
