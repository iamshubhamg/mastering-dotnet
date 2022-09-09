public class Solution 
{
    public bool IsAnagram(string s, string t)
    {
       string s1 = new string (s.OrderBy(c => c).ToArray());
        string s2 = new string (t.OrderBy(c => c).ToArray());
        for(int i=0; i< s.Length; i++)
        {
            if(s1[i] != s2[i])
            {
                return false;
            }
        }
        return true;
    }
}
