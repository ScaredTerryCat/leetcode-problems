public class Solution {
    public static int swap(int num,int a,int b){
        string snum=Convert.ToString(num);
        int len=snum.Length;
        string snum2=String.Empty;
        for(int i=0;i<len;i++){
            if(i==a){
                snum2+=snum[b];
            }
            else if(i==b){
                snum2+=snum[a];
            }
            else{
                snum2+=snum[i];
            }
        }
        int num2=Convert.ToInt32(snum2);
        return num2;
    }
    public int MaximumSwap(int num) {
        int max=num;
        int len=(Convert.ToString(num)).Length;
        for(int i=0;i<len-1;i++){
            for(int j=i+1;j<len;j++){
                int potential=swap(num,i,j);
                if(potential>max){max=potential;}
            }
        }
    return max;}
}
