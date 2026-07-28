public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // //outer loop
        // for (int i = 0; i < nums.Length; i++) {
        //     //inner loop
        //     for (int j = i + 1; j < nums.Length; j++){
        //         if (nums[i] + nums[j] == target) {
        //             return new int[] {i, j};
        //         }
        //     }
        // }
        // return null;


        //Hashing way
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int currentNum = nums[i];
            int complement = target - currentNum; // the number we need

            //we check if the number is already in the dictionary or not.
            if (seenNumbers.ContainsKey(complement)) {
                //we found the match. Return the stored inex and the current one
                return new int[] {seenNumbers[complement], i};
            }

            //if it wasnt a match, save the current number for later search
            if (!seenNumbers.ContainsKey(currentNum)) {
                seenNumbers.Add(currentNum, i);
            }
        }

        return null;
    }
}
