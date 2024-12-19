public class Solution {
    public bool charInString(char c ,string s){
        for(int i=0;i<s.Length;i++){if(s[i]==c){return true;}}
        return false;
    }
    public int LengthOfLongestSubstring(string s) {
        int maxLen=0;
        for(int i=0;i<s.Length;i++){
            string sub="";
            int len=0;
            for(int j=i;j<s.Length;j++){
                if(charInString(s[j],sub)){
                    break;
                }
                sub+=s[j];
                len++;
                if(len>maxLen){maxLen=len;}
            }
        }
        return maxLen;
    }
}
