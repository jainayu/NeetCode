public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> uniqueEmails = new HashSet<string>();
        foreach (string email in emails)
        {
            string[] components = email.Split("@");
            components[0] = components[0].Split("+")[0];
            components[0] = components[0].Replace(".", "");
            uniqueEmails.Add(components[0] + "@" + components[1]);
        }
        return uniqueEmails.Count;
    }
}