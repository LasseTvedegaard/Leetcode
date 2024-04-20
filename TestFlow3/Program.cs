using System;
using System.Collections.Generic;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        int i = 0; // Pointer for unique elements

        foreach (int num in nums) {
            if (!set.Contains(num)) {
                nums[i++] = num;
                set.Add(num);
            }
        }

        return set.Count;
    }

    public static void Main(string[] args) {
        Solution solution = new Solution();

        int[] nums = { 1, 1, 2, 2, 3, 4, 5, 5, 6 }; 
        int uniqueCount = solution.RemoveDuplicates(nums); 
        Console.WriteLine($"Antal unikke elementer: {uniqueCount}");
        Console.Write("Array efter fjernelse af duplikater: [");
        for (int i = 0; i < uniqueCount; i++) {
            Console.Write($"{nums[i]}, ");
        }
        Console.WriteLine("]");
    }
}
