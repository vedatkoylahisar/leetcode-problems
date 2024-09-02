public class Solution {
    public bool IsPowerOfTwo(int n) {
        
       if (n <= 0) 
            return false; 

        while (n > 1) {
            if (n % 2 != 0) {
                return false; 
            }
            n = n / 2;
        }

        return n == 1; // If n is reduced to 1, it's a power of two
 

    }
}