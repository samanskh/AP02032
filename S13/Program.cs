using System.Diagnostics;

namespace S13;
class AutoStopWatch: IDisposable
{
    public Stopwatch sw;
    public void Dispose()
    {
        sw.Stop();
        System.Console.WriteLine(sw.ElapsedMilliseconds);
    }

    public AutoStopWatch(string str)
    {
        Stopwatch s = Stopwatch.StartNew();
        sw = s;
    }
    
}
class person
{
    public int Age;
    public int Id;
    string Name;
    public person(int age,int id,string name)
    {
        this.Age = age;
        this.Id = id;
        this.Name=name;
    }
    public override string ToString()
    {
        return $"{this.Name}:{this.Id}:{this.Age}";
    }
}
class agecomparer : IComparer<person>
{
    public int Compare(person x, person y)
    {
        return x.Age.CompareTo(y.Age);
    }
}
class idcomparer : IComparer<person>
{
    public int Compare(person x, person y)
    {
        return x.Id.CompareTo(y.Id);
    }
}

class Program
{
    static void Main(string[] args)
    {

        
        string str = "ali";
        using(new AutoStopWatch(str))
        {
            System.Console.WriteLine("start");
        }
        person [] people = new person[6]{new person(10,20,"ali"),
        new person(11,19,"mammad"),
        new person(12,18,"hasan"),
        new person(13,17,"saman"),
        new person(14,16,"reza"),
        new person(15,15,"kazem"),
        };
        Array.Sort(people,new idcomparer() );
        for(int i = 0;i<people.Length;i++)
        {
            System.Console.WriteLine(people[i]);
        }
        System.Console.WriteLine("...............");
        Array.Sort(people,new agecomparer());
        for(int i = 0;i<people.Length;i++)
        {
            System.Console.WriteLine(people[i]);
        }
    }
}
