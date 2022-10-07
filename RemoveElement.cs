public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0; 
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == val){
                count++;
                nums[i] = Int32.MaxValue;
            }
        }
        Array.Sort(nums);
        
        return nums.Length - count;
        
    }
}