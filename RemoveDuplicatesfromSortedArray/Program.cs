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
}