public static class Test
{
    const string c = "abcdefghijklmnopqrstuvwxyz";
    public static string Sezar(this string a)
    {
        string o = "";
        foreach(char i in a)
        {
            bool T =false;
            for(int j = 0 ;j<c.Length-3;j++)
            {
                if (i==c[j])
                {
                    o+=c[j+3];
                    T = true;
                }
                if(i=='x')
                {
                    o+='a';
                    T=true;
                }
                if(i=='y')
                {
                    o+='b';
                    T=true;
                }
                if(i=='z')
                {
                    o+='c';
                    T=true;
                }
            }
            if(!T)
            {
                o+=i;
                T=true;
            }
        }
        return o;
    }
}