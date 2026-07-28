public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //outer loop
        for (int i = 0; i < nums.Length; i++) {
            //inner loop
            for (int j = i + 1; j < nums.Length; j++){
                if (nums[i] + nums[j] == target) {
                    return new int[] {i, j};
                }
            }
        }
        return null;
    }
}
