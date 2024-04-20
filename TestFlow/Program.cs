namespace TestFlow {
    public class Program {
        static void Main(string[] args) {
            int[] nums = { 2, 7, 3, 9, 8 };
            int target = 10;

            int[] result = TwoSum(nums, target);

            if (result != null) {
                Console.WriteLine("Indexes: [{0}, [{1}]", result[0], result[1]);
            } else {
                Console.WriteLine("No match");
            }
        }

        static int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target) {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
