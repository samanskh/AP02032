namespace S15;

class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle("c1","blue",0,0,2);
        Square s1 = new Square("s1","red",1,2,3);
        Rectangle r1 = new Rectangle("r1","pink",-1,-1,2,2);
        c1.PrintFeatures();
        s1.PrintFeatures();
        r1.PrintFeatures();
        ///////////////////
        c1.MoveTo(0,0);
        s1.MoveTo(0,0);
        r1.MoveTo(0,0);
        //////////////////
        c1.PrintFeatures();
        s1.PrintFeatures();
        r1.PrintFeatures();
        System.Console.WriteLine(c1.Area());
        System.Console.WriteLine(s1.Area());
        System.Console.WriteLine(r1.Area());
        c1.IsPointInside(1,1);
        s1.IsPointInside(1,1);
        r1.IsPointInside(1,1);
        System.Console.WriteLine(c1.Perimeter());
        System.Console.WriteLine(s1.Perimeter());
        System.Console.WriteLine(r1.Perimeter());
        c1.ScaleRadius(5);
        s1.ScaleSide(5);
        r1.ScaleHeight(8);
        r1.ScaleWidth(10);
        //out:

            //c1:blue:0:0
            // s1:red:1:2
            // r1:pink:-1:-1
            // c1:blue:0:0
            // s1:red:0:0
            // r1:pink:0:0
            // 12.566370614359172
            // 9
            // 4
            // True
            // True
            // False
            // 12.566370614359172
            // 12
            // 8
            // c1:blue:0:0:5
            // s1:red:0:0:5
            // r1:pink:0:0:2:8
            // r1:pink:0:0:10:8
    }
}
