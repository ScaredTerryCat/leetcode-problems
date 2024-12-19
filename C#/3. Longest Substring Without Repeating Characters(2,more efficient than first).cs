public class Solution {
    private Tuple<int,int> expandAroundCenter(string s,int start,int end){
            if(start<0 || end>s.Length-1){return new Tuple<int,int>(-1,-1);}
            if(s[start]!=s[end]){return new Tuple<int,int>(-1,-1);}
            while(start>0 && end<s.Length-1 && s[start-1]==s[end+1]){
                start--;
                end++;
            }
            return new Tuple<int,int>(start,end);
        }
    public string LongestPalindrome(string s) {
        string longest="";
        int n=s.Length;
        for(int i=0;i<n;i++){
            int start,end;
            (start,end)=expandAroundCenter(s,i,i);
            string potential="";
            if(start!=-1 && end!=-1){
            for(int j=start;j<=end;j++){
                potential+=s[j];
            }
            longest=(potential.Length > longest.Length)?potential:longest;}
            potential="";
            (start,end)=expandAroundCenter(s,i,i+1);
            if(start!=-1 && end!=-1){
            for(int j=start;j<=end;j++){potential+=s[j];}
            longest=(potential.Length>longest.Length)?potential:longest;}
        }
    return longest;   }
}
