public class Solution {
    public bool IsUgly(int n) {
        if (n <= 0) return false; 
        List<int> factors = new List<int>();

        while (n % 2 == 0) {
            factors.Add(2);
            n /= 2;
        }

        for (int i = 3; i <= Math.Sqrt(n); i += 2) {
            while (n % i == 0) {
                factors.Add(i);
                n /= i;
            }
        }

        if (n > 2) {
            factors.Add(n);
        }

        foreach (int factor in factors) {
            if (factor != 2 && factor != 3 && factor != 5) {
                return false; 
            }
        }

        return true; 
    }
}