public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res = strs[0];
        for(int i = 1; i < strs.Length; i++){
            string temp = "";
            for(int j = 0; j < Math.Min(res.Length, strs[i].Length); j++){
                if(res[j] == strs[i][j]){
                    temp += res[j];
                } else {
                    break;
                }
            }
            res = temp;
        }
        return res;
    }
}