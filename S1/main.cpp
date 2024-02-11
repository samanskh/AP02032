#include <iostream>
#include <math.h>

using namespace std;

class Point
{
public:
    int m_x; 
    int m_y;

    Point(int x, int y)
    {   
        m_x = x;
        m_y = y;
    }

    double diff(Point p)
    {
            double xdiff = m_x - p.m_x;
            double ydiff = m_y - p.m_y;
            return sqrt(xdiff * xdiff + ydiff * ydiff);
    }


};

class circle
{
public:
    double r;
    Point o;
    circle(double x, Point y)
    :o(y.m_x,y.m_y)
    {
        r = x;
        o = y;
    }
    double circumference()
    {
        return 2*M_PI*r;
    }
    double area()
    {
        return M_PI*r*r;
    }
    double distanceto(const circle& a)
    {   
        Point o1 = a.o;
        double distanceo = o1.diff(o);
        return abs(distanceo - r - a.r);
    }
    double distanceto(const Point& a)
    {
        return abs(o.diff(a));
    }
};

int main()
{
    Point p1(3, 4);
    double r1 = 2.5;
    circle c1(r1,p1);
    Point p2(1, 2);
    double r2 = 1.25;
    circle c2(r2,p2);

    cout << c1.circumference() << endl;
    cout << c1.area() << endl;
    cout << c1.distanceto(c2) << endl;
    cout << c1.distanceto(p2) << endl;
    return 0;
}

