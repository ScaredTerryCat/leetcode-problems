public class Solution {
    public bool isDuplicate(List<int> aux,IList<IList<int>> results){
        foreach(List<int> result in results){
            if(result[0]==aux[0] && result[1]==aux[1] && result[2]==aux[2]){return true;}
        }
    return false;}
    public int[] quickSort(int[] arr,int n=-1){
        if(n==-1){n=arr.Length;}
        if(n<=1){return arr;}
        int pivot=arr[n-1];
        List<int> l1=new List<int>();
        List<int> l2=new List<int>();
        for(int i=0;i<n-1;i++){
            if(arr[i]<pivot){l1.Add(arr[i]);}
            else{l2.Add(arr[i]);}
        }
        int n1=l1.Count,n2=l2.Count;
        int[] arr1=new int[n1],arr2=new int[n2];
        for(int i=0;i<n1;i++){
            arr1[i]=l1[i];
        }
        for(int i=0;i<n2;i++){
            arr2[i]=l2[i];
        }
        arr1=quickSort(arr1,n1);
        arr2=quickSort(arr2,n2);
        int[] result=new int[n];
        int r=0;
        for(int i=0;i<n1;i++){
            result[r]=arr1[i];
            r++;
        }
        result[r]=pivot;
        r++;
        for(int i=0;i<n2;i++){
            result[r]=arr2[i];
            r++;
        }
    return result;}
    public IList<IList<int>> ThreeSum(int[] nums) {
        int n=nums.Length;
        nums=quickSort(nums);
        List<IList<int>> result=new List<IList<int>>();
        for(int i=0;i<n-2;i++){
            for(int j=i+1;j<n-1;j++){
                for(int k=j+1;k<n;k++){
                    if(nums[i]+nums[j]+nums[k]==0){
                        List<int> aux=new List<int>{nums[i],nums[j],nums[k]};
                        if(!isDuplicate(aux,result)){
                            result.Add(aux);
                        }
                    }
                }
            }
        }
    return result;}
}
