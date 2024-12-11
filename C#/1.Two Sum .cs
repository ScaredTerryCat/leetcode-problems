public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> valueToIndex=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int complement=target-nums[i];
            if(valueToIndex.ContainsKey(complement)){
                return new int[]{valueToIndex[complement],i};
            }
            else{
                valueToIndex[nums[i]]=i;
            }
        }
    return new int[] {};}
}
