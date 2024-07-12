public class Solution {
    public double MyPow(double x, int n) {
        double current =x;
        if(x==1)
        {
            return x;
        }
        if(n==0)
        {
            return 1;
        }
        long N = n; // Üs değerini long veri türüne dönüştürüyoruz.
        if (N < 0)
        {
            
            x = 1 / x;
            current =x;
            if(N!=Int32.MinValue)
            {
                 N = -N; // Negatif üs değerini pozitif yapıyoruz.
            }
            else
            {
                current*=current;
                N=(N/2)* -1;
            }
       
        }    
        double output = 1;
        while(N>0)
             {
                if(N%2==1)
                {
                    output*=current;
                }
                current*=current;
                N/=2;
             }
        
               return output;
       
    }
}