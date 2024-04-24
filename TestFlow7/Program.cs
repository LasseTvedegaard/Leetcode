namespace TestFlow7 {
    internal class Program {
        static void Main(string[] args) {
            int[] nums = {2, 2, 3, 3, 4};
            Solution solution = new Solution();
            int result = solution.SingleNumber(nums);
            Console.WriteLine("The single number is: " + result);
        }
    }

    public class Solution {
        public int SingleNumber(int[] nums) {
            int result = 0;
            foreach (int num in nums) {
                result ^= num;
            }
            return result;
        }
    }
}
