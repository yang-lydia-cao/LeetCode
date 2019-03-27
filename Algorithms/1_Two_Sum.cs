public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary<string, int> dictionary = new Dictionary<string, int>();
        var numAndIndex = new Dictionary<int, int>();
        //
        for(int i = 0; i < nums.Length; i++)
        {
            var curNumber = nums[i];
            var numberA = target - curNumber;
            // See whether it contains this string.
            //if (!dictionary.ContainsKey("acorn"))
            if (numAndIndex.ContainsKey(numberA))
            {
                return new int[] {numAndIndex[numberA], i};
            }

            numAndIndex[curNumber] = i;
        }
        return null;
    }
}