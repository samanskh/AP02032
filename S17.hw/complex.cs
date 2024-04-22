public class complex
{
    public int Real;
    public int Im;
    public complex(int a,int b )
    {
        this.Real = a;
        this.Im = b;
    }
    public static complex operator +(complex a,complex b)
    {
        return new complex(a.Real+b.Real,a.Im+b.Im);
    }
        public static complex operator -(complex a,complex b)
    {
        return new complex(a.Real-b.Real,a.Im-b.Im);
    }
        public static complex operator -(complex a)
    {
        return new complex(-a.Real,-a.Im);
    }
        public static complex operator *(complex a,complex b)
    {
        return new complex(a.Real*b.Real,a.Im*b.Im);
    }
        public static complex operator /(complex a,complex b)
    {
        if (b.Real == 0 || b.Im ==0)
        {
            return new complex(0,0);
        }
        return new complex(a.Real/b.Real,a.Im/b.Im);
    }

}