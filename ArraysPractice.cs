using System;
using System.Collections.Generic;

namespace LeetCodePractice
{
    class ArraysPractice
    {
        /// <summary>
        ///  Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        ///  You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///  You can return the answer in any order.
        /// Example 1:
        /// Input: nums = [2, 7, 11, 15], target = 9
        /// Output: [0,1]
        /// Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// Example 2:
        /// Input: nums = [3, 2, 4], target = 6
        /// Output: [1,2]
        /// Example 3:
        /// Input: nums = [3, 3], target = 6
        /// Output: [0,1]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
		public int[] TwoSum(int[] nums, int target)
		{
			Dictionary<int, int> d = new Dictionary<int, int>();
			//all the complements on the dictionary
			for (int i = 0; i < nums.Length; i++)
			{
				if (d.ContainsKey(nums[i]))
				{
					if (target == (2 * nums[i]))
						return new int[] { d[nums[i]], i };
				}
				else
				{
					d.Add(nums[i], i);
				}
			}

			for (int i = 0; i < nums.Length; i++)
			{
				if (d.ContainsKey(target - nums[i]) && i != d[target - nums[i]])
					return new int[] { i, d[target - nums[i]] };
			}

			return null;
		}

        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// If there is no common prefix, return an empty string "".
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        static public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];

            //The array have to contain at leats two elements

            string commonPrefix = "";
            //first we have to find a common prefix in the first two strings of the array

            for (int i = 0; i < strs[0].Length; i++)
            {
                if (i < strs[1].Length && strs[0][i] == strs[1][i])
                {
                    commonPrefix += strs[0][i];
                }
                else
                {
                    if (i == 0)
                        return "";//if there is no common prefix in these two words 
                    else
                        break;
                }
            }
            if (commonPrefix == "")//there is no common prefix but common length
                return "";

            int j = 2; //to check the rest of the array
            while (commonPrefix != "" && j < strs.Length)
            {
                if (strs[j] == "")
                    return "";
                for (int k = 0; k < commonPrefix.Length; k++)
                {
                    if (k >= strs[j].Length)
                    {
                        commonPrefix = commonPrefix.Substring(0, k);
                        break;
                    }
                    if (k < strs[j].Length && commonPrefix[k] != strs[j][k])
                    {
                        if (k == 0)
                            return "";
                        else
                        {
                            commonPrefix = commonPrefix.Substring(0, k);
                            break;
                        }
                    }

                }
                j++;
            }



            return commonPrefix;
        }


        //static void Main(string[] args)
        //{
        //	Console.WriteLine("Hello World!");
        //}
    }
}
