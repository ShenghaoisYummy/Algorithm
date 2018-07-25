public class Solution {
    public int ArrayPairSum (int[] nums) {
        Array.Sort (nums);
        int sum = 0;
        for (int i = 0; i < nums.Length; i += 2) {
            sum += nums[i];
        }
        return sum;
    }

    static void Main(string[] args){
        int [] nums = {1, 3, 5, 6, 2, 3, 4, 6};
        Solution test = new Solution();
        int testresult = test.ArrayPairSum(nums);
        Console.WriteLine(testresult);
    }
}

