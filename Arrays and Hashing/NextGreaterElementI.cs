public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> indexesNum1 = new Dictionary<int, int>();
        int[] res = new int[nums1.Length];
        Stack<int> s = new Stack<int>();

        // initializing res and finding indexes
        for (int i = 0; i < nums1.Length; i++)
        {
            indexesNum1[nums1[i]] = i;
            res[i] = -1;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            int curr = nums2[i];
            while (s.Count != 0 && curr > s.Peek())
            {
                int val = s.Pop();
                int index = indexesNum1[val];
                res[index] = curr;
            }
            if (indexesNum1.ContainsKey(curr))
            {
                s.Push(curr);
            }
        }

        return res;
    }
}