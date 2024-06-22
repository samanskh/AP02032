namespace E2;
public interface ISpecialNumberNotifierContainer
{
    void add(int x);
    event Action<int> SpecialNumberAdded;
    Func<int,bool> SpecialNumberIdentifier { get; set; }
    int this[int i] { get;  set; }
}
public class SpecialNumberNotifierContainer : ISpecialNumberNotifierContainer
{
    public int[] a = new int[200];
    public int current = 0;
    public void add(int x)
    {
        a[current] = x;
        if(SpecialNumberIdentifier != null)
            if(SpecialNumberIdentifier(a[current]))
            {
                SpecialNumberAdded(x);
            }
        current ++;
    }
    public event Action<int> SpecialNumberAdded;
    public Func<int,bool> SpecialNumberIdentifier { get; set; }
    public int this[int i]
    {
        get{
            return a[i];
        }
        set{
            a[i] = value;
        }
    }
}