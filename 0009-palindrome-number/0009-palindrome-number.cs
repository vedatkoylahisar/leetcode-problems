public class Solution {
    public bool IsPalindrome(int x) {

        // Negative numbers are not palindromes
        if (x < 0) {
            return false;
        }

        // Store the original number
        int original = x;
        int reversed = 0;

        // Reverse the integer
        while (x != 0) {
            int remainder = x % 10;
            reversed = reversed * 10 + remainder;
            x /= 10;
        }

        return original == reversed;
    }
}