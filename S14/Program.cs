namespace S14;

class Program
{
    static void Main(string[] args)
    {
        StringSizeEnumerable test = new StringSizeEnumerable("samalirezkambis",3);
        foreach(string s in test)
        {
            System.Console.WriteLine(s);
        }
        ////////////////////////
        NumberBitEnumerator test2 = new NumberBitEnumerator(10);
        foreach(var i in test2)
        {
            System.Console.WriteLine(i);
        }
        ////////////////////////
        IAnimal[] zoo = new IAnimal[3]{new Lion(),new Cat(),new Dog()};
        foreach(var i in zoo)
        {
            System.Console.WriteLine($"{i.move} - {i.makesound}");
        }
    }
}
