public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res = "";
        
        for(int i = 0; i < strs[0].Length; i++){
            foreach(string s in strs){
                if(i == s.Length || s[i] != strs[0][i]){
                    return res;
                }
            }
            res += strs[0][i];
        }
        return res;
    }
}