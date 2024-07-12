public class Solution {
    public bool CheckPerfectNumber(int num) {
        int sayac=0;
        for(int i=1;i<=num/2;i++)
        {
            if(num%i==0)
            {
                sayac+=i;
                
            }
        }
        if(sayac==num)
        {
            return true;
        }
        else 
           return false;
        
    }
}