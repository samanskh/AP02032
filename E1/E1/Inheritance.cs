using System.Reflection.Metadata;

namespace E1;

public abstract class Person
{
    public string _Name;
    public virtual string Name{
        get{
            return _Name;
        }
        set{
            if(IsFemale)
                _Name ="خانم "  + value;
            else
            {
                _Name = "آقای " + value;
            }    
        }
    }
    public bool IsFemale{get;}
    
    public abstract int LunchRate {get;}
   public Person(string name,bool isFemale)
   {
    if(isFemale)
    {
        this._Name = "خانم " + name;
    }
    else{
        this._Name = "آقای " + name;
    }
    
    // this._Name = name;
    this.IsFemale = isFemale;
   }
}

public class Student:Person
{
    public override int LunchRate => 2000;
    public Student(string name,bool isFemale):base(name,isFemale)
    {
    }
}

public class Employee :Person
{   
    public override int LunchRate => 5000;
    public Employee(string name,bool isFemale):base(name,isFemale)
    {

    }
    public virtual int CalculateSalary(int a)
    {
        return 5000*a;
    }
}

public class Teacher :Employee
{

    public override string Name { get => _Name; set => _Name ="استاد "  + value; }
    public override int LunchRate => 10_000;
    public Teacher(string name,bool isFemale):base(name,isFemale)
    {

        this._Name = "استاد " + name;

    }
    public override int CalculateSalary(int a)
    {
        return 20_000*a;
    }
}