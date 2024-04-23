using System;

public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();

        int[] nums1 = new int[6] { 1, 3, 5, 0, 0, 0 };
        int m = 3;
        int[] nums2 = new int[3] { 2, 4, 6 };
        int n = 3;

        solution.Merge(nums1, m, nums2, n);

        Console.WriteLine("Merged array:");
        foreach (int num in nums1) {
            Console.Write(num + " ");
        }
    }
}

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }

        while (j >= 0) {
            nums1[k--] = nums2[j--];
        }
    }
}
