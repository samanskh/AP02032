namespace S17.hw;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        int[][] arr = new int[n][];
        for(int i = 1;i<n+1;i++)
        {
            arr[i-1] = new int[which_prime(i)];
            for(int j = 1;j<which_prime(i)+1;j++)
            {
                arr[i-1][j-1] = j;
            }
        }
        for (int i = 0;i<arr.GetLength(0);i++)
        {
            for(int j =0 ;j<arr[i].Length;j++)
            {
                System.Console.Write($"{arr[i][j]} ");
            }
            System.Console.WriteLine();
        }
    }
    static bool IS_Prime(int a)
    {
        if(a==2)
        {
            return true;
        }
        if (a<2)
        {
            return false;
        }
        for(int i=2;i<a;i++)
        {
            if (a%i==0)
            {
                return false;
            }
        }
        return true;
    }
    static int which_prime(int a)
    {
        int i = 0;
        while(a>0)
        {
            i++;
            if(IS_Prime(i))
            {
                a--;
            }
        }
        return i;
    }
}
    
