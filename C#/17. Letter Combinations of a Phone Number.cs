public class Solution {
    public void getCombinations(string digits,IList<string> il,Dictionary<int,string> dic,string result=""){
        if(digits.Length==1){int currentDigit=digits[0]-'0';
        string currentCharacters=dic[currentDigit];
        foreach(char character in currentCharacters){
            il.Add(result+character);
        }
        return;
        }
        if(digits.Length==0){return;}
        int digit=digits[0]-'0';
        string characters=dic[digit];
        digits=digits.Substring(1);
        foreach(char character in characters){
            getCombinations(digits,il,dic,result+character);
        }
        

    }
    public IList<string> LetterCombinations(string digits) {
        Dictionary<int,string> dic=new Dictionary<int,string>();
        
        dic[2]="abc";
        dic[3]="def";
        dic[4]="ghi";
        dic[5]="jkl";
        dic[6]="mno";
        dic[7]="pqrs";
        dic[8]="tuv";
        dic[9]="wxyz";
        IList<string> result=new List<string>();
        getCombinations(digits,result,dic);
        return result;
        
    }
}
