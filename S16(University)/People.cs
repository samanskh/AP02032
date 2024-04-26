using System.Runtime.CompilerServices;

public class Person
{
    public string FirstName{get;}
    public string LastName{get;}
    public int BirthYear{get;}
    public Person(string name,string lname,int birth)
    {
        this.FirstName = name;
        this. LastName = lname;
        this.BirthYear = birth;
    }

}
public class Teachers:Person,IStudentTeacher
{
    static int num = 1;
    public int Id{get;}
    public int salary{get;}
    List<Course> courses;
    public Teachers(string name,string lname,int birth,int salary):base(name,lname,birth)
    {
        this.Id = num;
        this.salary = salary;
        num ++;
        courses = new List<Course>();
    }
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
    public void RemoveCourse(Course course)
    {
        courses.Remove(course);
    }
    public void PrintCourses()
    {
        string output = "";
        foreach(var a in courses)
        {
            output += $"{a.course}({a.NumUnit}) / ";
        }
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine(output);
    }
    public override bool Equals(object obj)
    {
        var item = obj as Teachers;
        if (obj == null){
            
            return false; 
        }
        return this.Id.Equals(item.Id);
    }
}
public class Students:Person,IStudentTeacher,IStudent
{
    static int num = 1;
    public int Id{get;}
    List<Course> courses;
    List<Grade> grades;
    public Students(string name,string lname,int birth):base(name,lname,birth)
    {
        Id = num;
        num ++;
        courses = new List<Course>();
        grades = new List<Grade>();
    }
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
    public void RemoveCourse(Course course)
    {
        courses.Remove(course);
    }
    public void AddGrade(Grade grade)
    {
        grades.Add(grade);
    }
    public void RemoveGrade(Grade grade)
    {
        grades.Remove(grade);
    }
    public void PrintCourses()
    {
        string output = "";
        foreach(var a in courses)
        {
            output += a.course +  " / ";
        }
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine(output);
    }
    public void PrintGrades()
    {
        string output = "";
        foreach(var a in grades)
        {
            output += $"{a.course}({a.NumUnit}):{a.grade} / ";
        }
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine(output);
    }
    public int Avg()
    {
        int sum = 0;
        int count = 0;
        foreach(var a in grades)
        {
            sum += a.grade;
            count ++;
        }
        return sum/count;
    }
    public override bool Equals(object obj)
    {
        var item = obj as Students;
        if (obj == null){
            
            return false; 
        }
        return this.Id.Equals(item.Id);
    }
}
public class Employees:Person
{
    static int num = 1;
    public int Id{get;}
    public int salary{get;}
    public Employees(string name,string lname,int birth,int salary):base(name,lname,birth)
    {
        this.Id = num;
        num++;
        this.salary = salary;
    }
    public override bool Equals(object obj)
    {
        var item = obj as Employees;
        if (obj == null){
            
            return false; 
        }
        return this.Id.Equals(item.Id);
    }
}
public class StudentsGroup
{
    string Name;
    Students Head;
    List<Students> members;
    public StudentsGroup(string name, Students student)
    {
        this.Name = name;
        this.Head = student;
        members = new List<Students>();
    }
    public void AddMember(Students NewMember)
    {
        members.Add(NewMember);
    }
    public void RemoveMember(Students unwanted)
    {
        members.Remove(unwanted);
    }
    public override bool Equals(object obj)
    {
        var item = obj as StudentsGroup;
        if (obj == null){
            
            return false; 
        }
        return this.Head.Id.Equals(item.Head.Id);
    }
}