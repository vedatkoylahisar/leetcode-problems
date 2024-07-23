public class Solution {
    public int Reverse(int x) {
            int temp;
            long newnumber=0;
            while (x != 0) {
                temp = x % 10;  // Son basamağı al
                x = x / 10;  // Son basamağı çıkar
                newnumber = newnumber * 10 + temp;  // Tersine ekle
            }
            if (newnumber > int.MaxValue || newnumber < int.MinValue) {
                     return 0;
            }   
            return (int)newnumber;
    }
}