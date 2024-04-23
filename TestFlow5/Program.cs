namespace SearchInsertPosition {
    class Program {
        static void Main(string[] args) {
            int[] nums = { 1, 3, 5, 6 };
            int target = 6;

            Solution solution = new Solution();
            int result = solution.SearchInsert(nums, target);

            Console.WriteLine("Målværdi: " + target);
            Console.WriteLine("Index: " + result);
        }
    }

    public class Solution {
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