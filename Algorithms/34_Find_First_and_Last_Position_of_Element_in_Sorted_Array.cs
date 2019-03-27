public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        // int[] result = new int[2];
        int[] result = new int[] { -1, -1 };
        
        if(nums==null || nums.Length==0){
            return result;
        }
        
        // first binary search
        var start=0;
        var end=nums.Length-1;
        
        while(start+1<end){
            var mid=start+ (end-start)/2;
            if(nums[mid]>=target){
                end=mid;
            }
            else{
                start=mid;
            }            
        }
        
        if(nums[end]==target){
            result[0]=end;
        }
        if(nums[start]==target){
            result[0]=start;
        }
        
        // second binary search
        start=0;
        end=nums.Length-1;
        
        while(start+1<end){
            var mid=start+ (end-start)/2;
            if(nums[mid]<=target){
                start=mid;
            }
            else{
                end=mid;
            }            
        }
        
        if(nums[start]==target){
            result[1]=start;
        }
        if(nums[end]==target){
            result[1]=end;
        }
        
        return result;
    }
}