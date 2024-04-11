using System.Collections;

public class NumberBitEnumerator:IEnumerable<int>
{
    int num;
    public NumberBitEnumerator(int x)
    {
        this.num = x;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new NumberBit(this.num);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new NumberBit(this.num);
    }
}

internal class NumberBit : IEnumerator<int>
{
    int num;
    int current_place;
    List<int> token;

    public NumberBit(int x)
    {
        this.num = x;
        this.current_place = -1;
        this.token = new List<int>();

        while (num != 0)
        {
            this.token.Add(num & 1);
            num >>= 1;
        }
    }
    public int Current => token[current_place];

    object IEnumerator.Current => token[current_place];

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        current_place ++;
        return current_place < token.Count;
    }

    public void Reset()
    {
        current_place = -1;
    }
}