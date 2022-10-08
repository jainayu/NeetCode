public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int i = s.Length - 1;
        int end = 0;
        while (s[i] == ' ')
        {
            i--;
        }
        end = i;
        while (i >= 0 && s[i] != ' ')
        {
            i--;
        }
        return end - i;
    }
}

/*
// easily understandable approach
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int i = s.Length - 1;
        int len = 0;
        while (s[i] == ' ')
        {
            i--;
        }
        while (i >= 0 && s[i] != ' ')
        {
            len++;
            i--;
        }

        return len;
    }
}
*/