public class Solution {
    public int RomanToInt(string s) 
    {

        int a=s.Length;
        int sum=0;
        for(int i=0;i<a;i++)
        {
            if(s[i]=='I')
            {
                if (i + 1 < a && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                {
                    sum -= 1;
                }
                else
                {
                    sum += 1;
                }
            }
            else if(s[i]=='V')
            {
                sum+=5;
            }
            else if(s[i]=='X')
            {
                 if (i + 1 < a && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                {
                    sum -= 10;
                }
                else
                {
                    sum += 10;
                }
            }
            else if(s[i]=='L')
            {
                sum+=50;
            }
            else if(s[i]=='C')
            {

                 if (i + 1 < a && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                {
                    sum -= 100;
                }
                else
                {
                    sum += 100;
                }
            }
            else if(s[i]=='D')
            {
                sum+=500;
            }
            else if(s[i]=='M')
            {
                sum+=1000;
            }
        }
        return sum;
    }
}