using System.Reflection.Emit;

interface Ishape
{
    double Area();
    double Perimeter();
    bool IsPointInside(double x,double y);

}
public class ShapeClass
{
    public string Name;
    public string Color;
    public double X;
    public double Y;
    public ShapeClass(string name,string color,double x,double y)
    {
        this.Name = name;
        this.Color = color;
        this.X = x;
        this.Y = y;
    }
    public void PrintFeatures(){
        System.Console.WriteLine($"{Name}:{Color}:{X}:{Y}");
    }
    public void MoveTo(double newX,double newY)
    {
        this.X = newX;
        this.Y = newY;
    }
}
public class Circle : ShapeClass,Ishape
{
    double Radius;

    public Circle(string name,string color,double x,double y,double radius)
    :base(name,color,x,y)
    {
        this.Radius = radius;
    }
    public double Area()
    {
        return Radius*Radius*Math.PI;
    }

    public bool IsPointInside(double x, double y)
    {  
        System.Console.WriteLine((X-x<Radius || X-x>Radius) && (y-Y<Radius || y-Y>Radius));
        return (X-x<Radius || X-x>Radius) && (y-Y<Radius || y-Y>Radius);
    }

    public double Perimeter()
    {
        return 2*Math.PI*Radius;
    }

    public void ScaleRadius(double scaleFactor)
    {
        this.Radius = scaleFactor;
        System.Console.WriteLine($"{this.Name}:{this.Color}:{this.X}:{this.Y}:{this.Radius}");
    } 
    
}
public class Square:ShapeClass,Ishape
{

    double Side;
    public Square(string name,string color,double x,double y,double side)
    :base(name,color,x,y)
    {
        this.Side = side;
    }

    public double Area()
    {
        return Side*Side;
    }

    public bool IsPointInside(double x, double y)
    {
        System.Console.WriteLine((X-x<(Side/2) || X-x>(Side/2)) && (y-Y<(Side/2) || y-Y>(Side/2)));
        return (X-x<(Side/2) || X-x>(Side/2)) && (y-Y<(Side/2) || y-Y>(Side/2));
    }

    public double Perimeter()
    {
        return 4*Side;
    }
    public void ScaleSide(double scalefactor)
    {
        this.Side = scalefactor;
        System.Console.WriteLine($"{this.Name}:{this.Color}:{this.X}:{this.Y}:{this.Side}");
    }
}
public class Rectangle : ShapeClass,Ishape
{
    double Width;
    double Height;
    public Rectangle(string name,string color,double x,double y,double width,double height):base(name,color,x,y)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Area()
    {
        return Width*Height;
    }

    public bool IsPointInside(double x, double y)
    {
        System.Console.WriteLine((X-x<(Width/2) || X-x>(Width/2)) && (y-Y<(Height/2) || y-Y>(Height/2)));
        return (X-x<(Width/2) || X-x>(Width/2)) && (y-Y<(Height/2) || y-Y>(Height/2));
    }

    public double Perimeter()
    {
        return 2*(Height+Width);
    }
    public void ScaleWidth(double scalefactor)
    {
        this.Width = scalefactor;
        System.Console.WriteLine($"{this.Name}:{this.Color}:{this.X}:{this.Y}:{this.Width}:{this.Height}");
    }
    public void ScaleHeight(double scalefactor)
    {
        this.Height = scalefactor;
        System.Console.WriteLine($"{this.Name}:{this.Color}:{this.X}:{this.Y}:{this.Width}:{this.Height}");
    }
}