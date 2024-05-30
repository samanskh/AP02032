using System.Numerics;

namespace E1;

public partial class Basics
{
public static void Q0_Reverse(int[] a)
{   if(a.Length>0){
    int[] t = new int[a.Length];
    t[0] = a[0];
    t[a.Length-1] = a[a.Length-1];
    for(int i = a.Length-2;i>0;i--)
    {
        t[a.Length-i-1] = a[i];
    }
    for(int i = 0;i<a.Length;i++)
    {
        a[i] = t[i];
    }
}
}
public static int[] Q1_Reverse(int[] a)
{
    if(a.Length>0){
    int[] t = new int[a.Length];
    t[0] = a[0];
    t[a.Length-1] = a[a.Length-1];
    for(int i = a.Length-2;i>0;i--)
    {
        t[a.Length-i-1] = a[i];
    }
    return t;
    }
    else
    return new int[0];
}
public static void Q2_Reverse<T>(T[] a) 
{
    if(a.Length>0){
    T[] t = new T[a.Length];
    t[0] = a[0];
    t[a.Length-1] = a[a.Length-1];
    for(int i = a.Length-2;i>0;i--)
    {
        t[a.Length-i-1] = a[i];
    }
    for(int i = 0;i<a.Length;i++)
    {
        a[i] = t[i];
    }
}
}
public static int Q5_CalculateSum(string expression)
{
    string[] a = expression.Split('+');
            int o = 0;

            try{
            for(int i =0;i<a.Length;i++)
            {
                o += int.Parse(a[i]);
            }
            return o;
            }

            catch
            {
                int a1 = 0;
                int a2 = 0;
                foreach(char i in expression)
                {
                    if (i == '+')
                    {
                        a1++;
                    }
                    else
                    {
                        a2++;
                    }
                }
                if(a1+1 != a2)
                throw new InvalidDataException();
                throw new FormatException();
            }


    // string[] s = a.Split('+');
    // foreach(string i in s)
    // {
    //     if(i is not  null)
    //     {
    //         c++;
    //     }
    // }
    // if(plus+1 == c)
    // {
    //     throw new InvalidDataException();
    // }
    // else{
    // int o = 0;
    // foreach(string i in s)
    // {
    //     o+=int.Parse(i);
    // }
    // return o;
    // }
}
public static bool Q6_TryCalculateSum(string expression,out int result)
{
    string[] a = expression.Split('+');
            int o = 0;
            result = 0;
            try{
            for(int i =0;i<a.Length;i++)
            {
                o += int.Parse(a[i]);
            }
            result = o;
            return true;
            
            }

            catch
            {
                return false;
            }


                
}
}
public interface IHasAge
{
    public int GetAge();
}
public class Human:IHasAge
{
    public string Name;
    public int Age;
    public Human(string a,int b)
    {
        this.Name = a;
        this.Age = b;
    }

    public int GetAge()
    {
        return this.Age;
    }
}

#region TODO
// IHasAge
// Human
#endregion
