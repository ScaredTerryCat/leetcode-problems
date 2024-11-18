class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int longestLen=0;
        string longestStr="";
        string usedCharacters="";
        for(int i=0;i<s.size();i++){
            char currentCharacter=s[i];
            int repeatIndex=-1;
            for(int j=0;j<usedCharacters.size();j++){
                char usedCharacter=usedCharacters[j];
                if(currentCharacter==usedCharacter){repeatIndex=j;}
            }
            if(repeatIndex!=-1){
                if(longestStr.size() > longestLen){longestLen=longestStr.size();}
                //longestStr=currentCharacter;
                //usedCharacters=currentCharacter;
                longestStr="";
                for(int j=repeatIndex+1;j<usedCharacters.size();j++){
                    longestStr+=usedCharacters[j];
                }
                longestStr+=currentCharacter;
                usedCharacters=longestStr;
                if(longestStr.size()>longestLen){longestLen=longestStr.size();}
            }
            else{
                longestStr=longestStr+currentCharacter;
                usedCharacters=usedCharacters+currentCharacter;
                if(longestStr.size()>longestLen){longestLen=longestStr.size();}
            }
        }
    return longestLen;}
};
