namespace E2;
using System;

public class GameAnalysis
{
    public GameData[] GameDatas;
    public GameAnalysis(string path)
    {
        string[] lines = File.ReadAllLines(path);
        List<GameData> Games = new List<GameData>();
        for (int i = 1; i < lines.Length - 1; i++)
            try
            {
                var t = new GameData(lines[i].Replace(" ", "").Split(','));
                Games.Add(t);
            }
            catch
            {
            }
        GameDatas = Games.ToArray();
        
    }
    public long AllDataCount()
    {
        return GameDatas.Length;
    }
    public (string,long)[] MostFrequent()
    {
        (string,long)[] a = new (string,long)[5];
        var d = GameDatas.GroupBy(l => l.genre).OrderByDescending(l=>l.Count()).Take(5).Select(l => (genre:l.Key,count:l.Count()));
        int c = 0;
        foreach(var i in d)
        {
            a[c].Item1 = i.genre;
            a[c].Item2 = i.count;
            c++;
        }
        return a;
    }
    public double[] BestPublisher()
    {
        double[] a = new double[5];
        var d = GameDatas.Where(l => (l.year>2000)&&(l.year<2010)).GroupBy(l => l.publisher).OrderByDescending(l=>l.Count())
        .Take(5).Select(l => l.Key);
        string[] s = new string[5];
        int z = 0;
        foreach(var i in d)
        {
            s[z] = i;
            z++;
        }
        var n1 = GameDatas.Where(l => (l.year>2000)&&(l.year<2010)).Where(l => l.publisher == s[0]).Average(l => l.Global_sales);
        var n2 = GameDatas.Where(l => (l.year>2000)&&(l.year<2010)).Where(l => l.publisher == s[1]).Average(l => l.Global_sales);
        var n3 = GameDatas.Where(l => (l.year>2000)&&(l.year<2010)).Where(l => l.publisher == s[2]).Average(l => l.Global_sales);
        var n4 = GameDatas.Where(l => (l.year>2000)&&(l.year<2010)).Where(l => l.publisher == s[3]).Average(l => l.Global_sales);
        var n5 = GameDatas.Where(l => (l.year>2000)&&(l.year<2010)).Where(l => l.publisher == s[4]).Average(l => l.Global_sales);
        a[0] = Math.Round(n1,3);
        a[1] = Math.Round(n2,3);
        a[2] = Math.Round(n3,3);
        a[3] = Math.Round(n4,3);
        a[4] = Math.Round(n5,3);
        return a;
    }
    public string[] WestGamers(int limit1, int limit2)
    {
        string[] a = new string[limit2-limit1+1];
        throw new NotImplementedException();
    }
    public string FaultyDatas()
    {
        var d = GameDatas.OrderByDescending(l=>l.year).GroupBy(l=>l.name).Select(l=>l.Key).Take(10);
        foreach(var i in d)
        {

        }
        throw new NotImplementedException();

    }
}
