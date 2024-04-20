using System;

namespace TestFlow2 {
    internal class Program {
        static void Main(string[] args) {
            Solution solution = new Solution();

            // Test case 1
            string s1 = "abcabcbb";
            Console.WriteLine($"Input: {s1}");
            Console.WriteLine($"Output: {solution.LengthOfLongestSubstring(s1)}");
            Console.WriteLine();

            // Test case 2
            string s2 = "bbbbb";
            Console.WriteLine($"Input: {s2}");
            Console.WriteLine($"Output: {solution.LengthOfLongestSubstring(s2)}");
            Console.WriteLine();

            // Test case 3
            string s3 = "pwwkew";
            Console.WriteLine($"Input: {s3}");
            Console.WriteLine($"Output: {solution.LengthOfLongestSubstring(s3)}");
            Console.WriteLine();
        }
    }

    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            HashSet<char> set = new HashSet<char>();
            int maxLength = 0;
            int i = 0;
            int j = 0;

            while (j < s.Length) {
                if (!set.Contains(s[j])) {
                    set.Add(s[j]);
                    maxLength = Math.Max(maxLength, j - i + 1);
                    j++;
                } else {
                    set.Remove(s[i]);
                    i++;
                }
            }

            return maxLength;
        }
    }
}
