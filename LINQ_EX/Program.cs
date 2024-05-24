using System.ComponentModel.DataAnnotations;

namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Query 1
        Console.WriteLine("Query 1");
        IEnumerable<Data> lines = File.ReadAllLines("data.csv")
        .Skip(1)
        .Select(l => Data.Parse(l))
        .Where(l => l.Country == "brazil")     // brazil => iran
        .Where(l => l.LEType == LifeExpectancyType.AtBirth)
        .Where(l => l.DataGender == DataGender.Both)
        .OrderBy(l => l.Value);
        lines.ToList().ForEach(l => System.Console.WriteLine(l));
        System.Console.WriteLine();
        //Query 2
        Console.WriteLine("Query 2");
        List<double> value = lines.Select(l => l.Value).ToList();
        Console.WriteLine(Math.Abs(value[0] - value[value.Count-1]));
        System.Console.WriteLine();
        //Query 3
        Console.WriteLine("Query 3");
        File.ReadAllLines("data.csv")
        .Skip(1)
        .Select(l => Data.Parse(l))
        .Where(l => l.DataGender == DataGender.Both)
        .Where(l => l.LEType == LifeExpectancyType.AtBirth)
        .GroupBy(l => l.Country)
        .Select(l => (country:l.Key , year: l.MinBy(t => t.Value).Year , value: l.MinBy(t => t.Value) , maxdiff:Math.Abs(l.MaxBy(t=> t.Value).Value - l.MinBy(t => t.Value).Value)))
        .Select((i,t)=>(t+1,i))
        .ToList()
        .ForEach(l => System.Console.WriteLine(l)); 
        System.Console.WriteLine();
        //Query 4
        Console.WriteLine("Query 4");
        IEnumerable<Data> data = File.ReadAllLines("data.csv")
        .Skip(1)
        .Select(l => Data.Parse(l))
        .Where(l => l.LEType == LifeExpectancyType.AtBirth);
        data.Join(data
        ,(d1) => (d1.Year , d1.Country , d1.DataGender == DataGender.Male)
        ,(d2) => (d2.Year , d2.Country , d2.DataGender == DataGender.Female)
        ,(d1,d2) => (country: d1.Country , year: d1.Year , vm: d1.Value , vf:d2.Value , diff: Math.Abs(d1.Value - d2.Value)))
        .GroupBy(l => l.country)
        .Select(l => l.MaxBy(t=>t.diff))
        .OrderByDescending(l => l.diff)
        .Select((t,i) => (i+1,t))
        .ToList()
        .ForEach(l => System.Console.WriteLine(l));
        // .Select(l => (country: l.Country , year: l.Year , ))
        Console.WriteLine();

    }
}
