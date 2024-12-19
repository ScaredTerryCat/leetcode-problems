public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m=nums1.Length,n=nums2.Length;
        int[] nums3=new int[n+m];
        int index1=0,index2=0,index3=0;
        while(index1<m && index2<n){
            if(nums1[index1]<nums2[index2]){
                nums3[index3]=nums1[index1];
                index1++;
            }
            else{
                nums3[index3]=nums2[index2];
                index2++;
            }
            index3++;
        }
        while(index1<m){
            nums3[index3]=nums1[index1];
            index1++;
            index3++;
        }
        while(index2<n){
            nums3[index3]=nums2[index2];
            index2++;
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
