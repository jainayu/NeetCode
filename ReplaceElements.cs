public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int size = arr.Length;
        int max = -1;
        int newMax;
        
        for(int i = size - 1; i >= 0; i--){
            newMax = Math.Max(max, arr[i]);
            arr[i] = max;
            max = newMax;
        }
        
        return arr;
    }
}