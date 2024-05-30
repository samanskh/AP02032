using System.Runtime.CompilerServices;

namespace E1;

public class MyString
{
    public string str;
    public MyString(string a)
    {
        this.str = a;
    }
    public static explicit  operator MyString(string a)
    {
        return new MyString(a);
    }
    public static explicit  operator string(MyString a)
    {
        return a.str;
    }
    public static bool operator ==(MyString a,string b)
    {
        return a.str == b;
    } 
        public static bool operator !=(MyString a,string b)
    {
        return a.str != b;
    }
    public override bool Equals(object obj)
    {
        if (obj is string)
        {
            return this.str == (string)obj;
        }
        else{
            if(obj is MyString)
            {
                return false;
            }
            else
            {
                return this.str == (obj as MyString).str;
            }
        }

    }
    public static MyString operator ++(MyString a)
    {
        string o = "";
        foreach(char i in a.str)
        {
            o += char.ToUpper(i);
        }
        a.str = o;
        return a;
    }
    
    public static MyString operator --(MyString a)
    {
        string o = "";
        foreach(char i in a.str)
        {
            o += char.ToLower(i);
        }
        a.str = o;
        System.Console.WriteLine(a);
        return a;
    }
    public override string ToString()
    {
        return this.str;
    }
}
