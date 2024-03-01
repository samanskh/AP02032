namespace S6;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("saman.csv");
        List<int> nums = new List<int>();
        for (int i = 0;i<lines.Length;i++)
        {
            nums.Add(int.Parse(lines[i]));
        }
        if (args[0] == "add")
        {
            string[] linesadd = new string[lines.Length+1];
            for(int i =0;i<lines.Length;i++)
            {
                linesadd[i]=lines[i];
            }
            linesadd[lines.Length] = args[1];
            File.WriteAllLines("saman.csv",linesadd);
        }
        if (args[0] == "removeat")
        {
            int x = int.Parse(args[1]);
            nums.RemoveAt(x);
            string[] lines_removeat = new string[lines.Length-1];
            convert(nums,lines_removeat,lines.Length-1);
            File.WriteAllLines("saman.csv",lines_removeat);
        }
        if (args[0] == "remove")
        {
            int x = int.Parse(args[1]);
            nums.Remove(x);
            string[] lines_remove = new string[lines.Length-1];
            convert(nums,lines_remove,lines.Length-1);
            File.WriteAllLines("saman.csv",lines_remove);
        }
        if (args[0] == "removeall")
        {
            int x = int.Parse(args[1]);
            int count = nums.Count(num => num == x);
            nums.RemoveAll(num => num == x);
            string[] lines_removeall = new string[lines.Length-count];
            convert(nums,lines_removeall,lines.Length-count);
            File.WriteAllLines("saman.csv",lines_removeall);
        }
        if (args[0] == "list")
        {
            for(int i=0;i<lines.Length;i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        if (args[0] == "max")
        {
            int c = nums.Max();
            Console.WriteLine(c);
        }
        if (args[0] == "min")
        {
            int c = nums.Min();
            Console.WriteLine(c);
        }
        if (args[0] == "reverse")
        {
            string[] lines2 = new string[lines.Length];
            for (int i=0;i<lines.Length;i++)
            {
                lines2[i] = lines[lines.Length-i-1];
            }
            File.WriteAllLines("saman.csv",lines2);
        }
        if (args[0] == "sort")
        {
            nums.Sort();
            convert(nums,lines,lines.Length);
            File.WriteAllLines("saman.csv",lines);
        }
        
    }
    static void convert(List<int> nums,string[] lines, int Length)
    {
        for(int i = 0;i<Length;i++)
        {
            lines[i]=nums[i].ToString();
        }
    }

}
