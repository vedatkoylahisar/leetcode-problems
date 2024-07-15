public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        int min = int.MaxValue;
        string minword = strs[0];
        int uzunluk = strs.Length;

        for (int i = 0; i < uzunluk; i++)
        {
            if (strs[i].Length < min)
            {
                min = strs[i].Length;
                minword = strs[i];
            }
        }

        char[] minwordharfler = minword.ToCharArray();
        StringBuilder ortakharfler = new StringBuilder();

        for (int j = 0; j < minwordharfler.Length; j++)
        {
            bool allMatch = true;
            for (int k = 0; k < strs.Length; k++)
            {
                if (strs[k][j] != minwordharfler[j])
                {
                    allMatch = false;
                    break;
                }
            }
            if (allMatch)
            {
                ortakharfler.Append(minwordharfler[j]);
            }
            else
            {
                break;
            }
        }

        return ortakharfler.ToString();
    }
}
