public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m=nums1.Length,n=nums2.Length;
        int[] nums3=new int[n+m];
        int index3=0;
        for(int i=0;i<m;i++){
            nums3[index3]=nums1[i];
            index3++;
        }
        for(int i=0;i<n;i++){
            nums3[index3]=nums2[i];
            index3++;
        }
        Array.Sort(nums3);
        if((m+n)%2==0){
            int upMiddle=(m+n)/2;
            int lowMiddle=upMiddle-1;
            return (nums3[lowMiddle]+nums3[upMiddle])/2.0;
        }
        int middle=(m+n)/2;
        return nums3[middle];
    }
}
