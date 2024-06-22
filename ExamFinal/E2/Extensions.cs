public static class Extensions
{
    public static int[] To(this int a,int b)
    {
        int[] c = new int[b-a+1];
        int z = 0;
        for(int i = a;i<b+1;i++)
        {
            c[z] = i;
            z++;
        }
        return c;
    }
    public static int NextPrime(this int a)
    {
        bool c = true;
        while (c)
        {
            a++;
            if(is_prime(a))
            {
                c = false;
            }
        }
        return a;
    
    }
    public static bool is_prime(int a)
    {
        for(int i = 2;i<a;i++)
        {
            if (a%i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
