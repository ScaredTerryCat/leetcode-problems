//11:57
public class Solution {
    public string remNotDigAfter(string s){
        int n=s.Length;
        int endIndex=n-1;
        for(int i=0;i<n;i++){
            if(s[i]!='1' && s[i]!='0' && s[i]!='2' && s[i]!='3' && s[i]!='4' && s[i]!='5' && s[i]!='6' && s[i]!='7' && s[i]!='8' && s[i]!='9'){endIndex=i-1;break;}
        }
        string result="";
        for(int i=0;i<=endIndex;i++){
            result+=s[i];
        }
    return result;}
    public string remFrontSpace(string s,int n=-1){
        if(n==-1){n=s.Length;}
        if(n==0){return "";}
        int i=0;
        while(s[i]==' '){i+=1;}
        string result="";
        for(int t=i;t<n;t++){
            result+=s[t];
        }
    return result;
    }
    public string remFrontZero(string s,int n=-1){
        if(n==-1){n=s.Length;}
        string result="";
        int start=0;
        while(s[start]=='0'){start++;}
        for(int i=start;i<n ;i++){
            result+=s[i];
        }
        return result;
    }
    public bool someValid(string s,int n=-1){
        if(n==-1){n=s.Length;}
        for(int i=0;i<n;i++){
            if(s[i]=='1' || s[i]=='2' || s[i]=='3' || s[i]=='4' || s[i]=='5' || s[i]=='6' || s[i]=='7' || s[i]=='8' || s[i]=='9'){return true;}
        }
    return false;}
    public int MyAtoi(string s) {
        if(!someValid(s)){return 0;}
        int maxValue=2147483647,minValue=-2147483648;
        int result=0;
        int sign=1;
        int n=s.Length;
        s=remFrontSpace(s);
        if(s[0]=='-'){sign*=-1;}
        if(s[0]=='-' || s[0]=='+'){
            n=s.Length;
            string s2="";
            for(int i=1;i<n;i++){s2+=s[i];}
            s=s2;
        }
        s=remFrontZero(s);
        s=remNotDigAfter(s);
        foreach(char c in s){
            int digit=c-'0';
            if(result<=(maxValue-digit)/10){
            result=result*10+digit;}
            else{
                if(sign==1){return maxValue;}
                else{return minValue;}
            }
        }
       
result*=sign;
return result;
    }
}
