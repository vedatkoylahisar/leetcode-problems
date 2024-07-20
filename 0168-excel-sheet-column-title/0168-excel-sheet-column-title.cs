public class Solution {
    public string ConvertToTitle(int columnNumber)
    {
        string sonuc = "";
        while (columnNumber > 0)
        {
            columnNumber--; 
            int kalan = columnNumber % 26;
            sonuc = (char)(kalan + 'A') + sonuc;
            columnNumber /= 26;
        }
        return sonuc;
    }
}
