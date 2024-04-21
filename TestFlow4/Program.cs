namespace TestFlow4 {
    public class Program {
        public static void Main(string[] args) {
            Solution solution = new Solution(); 
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;

            Console.WriteLine("Input array: [" + string.Join(", ", nums) + "]");
            Console.WriteLine("Value to remove: " + val);

            int resultLength = solution.RemoveElement(nums, val); 
            Console.WriteLine("Output length: " + resultLength);
            Console.Write("Modified array: [");
            for (int i = 0; i < resultLength; i++) {
                Console.Write(nums[i]);
                if (i < resultLength - 1) {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }

    public class Solution {
        public int RemoveElement(int[] nums, int val) {
            int k = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != val) {
                    nums[k++] = nums[i];
                }
            }
            return k;
        }
    }
}
