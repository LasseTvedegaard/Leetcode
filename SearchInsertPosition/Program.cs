﻿namespace SearchInsertPosition {
    public class solution {
        public int SearchInsert(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == target) {
                    return i;
                } else if (nums[i] > target) {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
