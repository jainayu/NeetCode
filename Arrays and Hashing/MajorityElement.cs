// Boyer-Moore

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int res = 0;
        int count = 0;

        foreach (int n in nums)
        {
            if (count == 0)
            {
                res = n;
            }
            count += (n == res ? 1 : -1);
        }

        return res;
    }
}