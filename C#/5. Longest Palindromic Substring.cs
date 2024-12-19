public class Solution {
    public bool isPalindrome(string s){
        int left=0,right=s.Length-1;
        while(left<right){
            if(s[left]!=s[right]){return false;}
        left++;
        right--;
        }
        return true;
    }
    public string LongestPalindrome(string s) {
     string longest="";
     int longestLength=0;
     for(int i=0;i<s.Length;i++){
        string potential="";
        int potentialLength=0;
        for(int j=i;j<s.Length;j++){
                potential+=s[j];
                potentialLength++;
                if(potentialLength>longestLength && isPalindrome(potential)){longestLength=potentialLength;
                longest=potential;
                
            }
        }
     }   
   return longest; }
}
