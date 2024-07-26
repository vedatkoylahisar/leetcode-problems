public class Solution {
    public int TitleToNumber(string columnTitle) {
        int sum=0;
        int uzunluk=columnTitle.Length;
        for(int i=0;i<uzunluk;i++)
        {
            sum = sum * 26 + (columnTitle[i] - 'A' + 1);
        }
        return sum;
    }
}