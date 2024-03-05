
using System.Text;

namespace S8.con;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("saman.csv");
        List<int> nums = new List<int>();
        for(int i= 0;i<lines.Length;i++)
        {
            string[] split = lines[i].Split(' ');
            nums.Add(int.Parse(split[1]));
        }
        nums.Sort();


        if (args[0] == "add")
        {
            string[] linesadd = new string[lines.Length+1];
            for(int i =0;i<lines.Length;i++)
            {
                linesadd[i]=lines[i];
            }
            linesadd[lines.Length] = args[1] + ' '+ args[2];
            File.WriteAllLines("saman.csv",linesadd);
        }
        if (args[0] == "removeat")
        {
            int x = int.Parse(args[1]);
            string[] lines_removeat = new string[lines.Length-1];
            removeat(lines,lines_removeat,x);
            File.WriteAllLines("saman.csv",lines_removeat);
        }
        if (args[0] == "remove")
        {
            int x = -1;
            string r = args[1] + ' ' + args[2];
            string[] lines_remove = new string[lines.Length-1];
            for(int i = 0;i<lines.Length;i++)
            {
                if (lines[i] == r)
                    {
                        x = i;
                    }
            }
            removeat(lines,lines_remove,x);
            File.WriteAllLines("saman.csv",lines_remove);
        }
        if (args[0] == "removeall")
        {
            int x = int.Parse(args[2]);
            int count = nums.Count(num => num == x);
            nums.RemoveAll(num => num == x);
            string[] lines_removeall = new string[lines.Length-count];
            convert(nums,lines_removeall,lines);
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
            string[] lines_sort = new string[lines.Length];
            convert2(nums,lines,lines_sort);
            File.WriteAllLines("saman.csv",lines_sort);
        }
        
    }

    static void convert2(List<int> nums, string[] lines, string[] lines_sort)
    {
        for(int i = 0;i<lines.Length;i++)
        {
            for(int j=0;j<lines.Length;j++)
            {
                string[] split = lines[j].Split(' ');
                int num = int.Parse(split[1]);
                if(nums[i] == num)
                {
                    lines_sort[i] = lines[j];
                }
            }
        }
    }

    static void convert(List<int> nums, string[] lines_removeall,string[] lines)
    {
        int i = 0;
        int j = 0;
        while(j<lines_removeall.Length)
        {
            string[] split = lines[i].Split(' ');
            int num = int.Parse(split[1]);
            if(nums[j] == num)
            {
                lines_removeall[j] = lines[i];
                j++;
            }
            i++;
        }
    }

    static void removeat(string[] lines,string[] lines2, int x)
    {
        for(int i = 0;i<lines.Length-1;i++)
        {
            if(i<x)
            {
            lines2[i]=lines[i];
            }     
            if(i>x)
            {
                lines2[i-1] = lines[i];
            }   
        }
    }
}
