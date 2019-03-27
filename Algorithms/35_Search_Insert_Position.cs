public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int start = 0;
        int end = nums.Length - 1;
        
        while(start +1 < end)
        {
            int mid= (start+end)/2;

            if(nums[mid] == target)
                return mid;
            else if(nums[mid] > target)
                end = mid;
            else {
                start=mid;
            }
        }
        
        if(nums[end] < target){
            return end+1;
        }
        else if (nums[start] >= target) {
            return start;            
        }
        else{
            return end; 
        }
    }
}