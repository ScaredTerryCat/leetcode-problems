// Online C++ compiler to run C++ program online
#include <iostream>
using namespace std;
class Solution {
public:
    int max(int a,int b){return a>b?a:b;}
    bool isPalindrome(string s){
        int n=s.size();
        int start=0;
        int end=n-1;
        while(start<=end){
            if(s[start]!=s[end]){return false;}
            start++;
            end--;
        }
    return true;}
    string longestPalindrome(string s) {
        int n=s.size();
        if(n==0){return "";}
        if(isPalindrome(s)){return s;}
        string s1="",s2="";
        for(int i=0;i<n-1;i++){s1+=s[i];}
        for(int i=1;i<n;i++){s2+=s[i];}
        string r1=longestPalindrome(s1);
        string r2=longestPalindrome(s2);
        if(max(r1.size(),r2.size())==r1.size()){return r1;}return r2;
    }
};
int main() {
    // Write C++ code here
    Solution s1;
    cout<<"Enter a string:\t";
    string s;
    getline(cin,s);
    string palindrome=s1.longestPalindrome(s);
    cout<<"Longest palindrome in "<<s<<": "<<palindrome;
    return 0;
}
