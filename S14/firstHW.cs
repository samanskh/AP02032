using System.Collections;
using System.Reflection.Metadata.Ecma335;

public class StringSizeEnumerable:IEnumerable<string>
{
    int size;
    string str;
    public StringSizeEnumerable(string str,int size)
    {
        this.str = str;
        this.size = size;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return new StringSize(this.str,this.size);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new StringSize(this.str,this.size);
    }
}

internal class StringSize : IEnumerator<string>
{
    int size;
    string str;
    string[] token;
    string str_final;
    int current_place;
    public StringSize(string str,int size)
    {
        this.str = str;
        this.size = size;
        for (int i =0;i<str.Length;i++)
        {
            
            if((i+1)%size==0)
            {
                str_final += str[i];
                str_final += " ";
            }
            else
                str_final += str[i];
        }
        token = str_final.Split(new char[]{' '});
        current_place = -1;
    }
    public string Current => token[current_place];

    object IEnumerator.Current => token[current_place];

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        current_place ++;
        return current_place < token.Length;
    }

    public void Reset()
    {
        current_place = -1;
    }
}