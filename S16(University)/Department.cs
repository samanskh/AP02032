public class Department:IDEpartment,IPlace
{
    string Name;
    Teachers Presidency;
    List<Teachers> teachers;
    List<Students> students;
    List<Employees> employees;
    List<StudentsGroup> studentsGroups;
    public Department(string name, Teachers head)
    {
        this.Name = name;
        this.Presidency = head;
        teachers = new List<Teachers>();
        students = new List<Students>();
        employees = new List<Employees>();
        studentsGroups = new List<StudentsGroup>();
    }
    public void AddTeacher(Teachers NewTeacher)
    {
        teachers.Add(NewTeacher);
    }
    public void RemoveTeacher(Teachers unwanted)
    {
        teachers.Remove(unwanted);
    }
    public void AddStudent(Students NewStudent)
    {
        students.Add(NewStudent);
    }
    public void RemoveStudent(Students unwanted)
    {
        students.Remove(unwanted);
    }
    public void AddEmployee(Employees NewEmployee)
    {
        employees.Add(NewEmployee);
    }
    public void RemoveEmployee(Employees unwanted)
    {
        employees.Remove(unwanted);
    }
    public void AddStudentsGroup(StudentsGroup NewStudentsGroup)
    {
        studentsGroups.Add(NewStudentsGroup);
    }
    public void RemoveStudentsGroup(StudentsGroup unwanted)
    {
        studentsGroups.Remove(unwanted);
    }
    public int ToltalSalary()
    {
        int sum = 0;
        foreach(var a in employees)
        {
            sum += a.salary;
        }
        foreach(var a in teachers)
        {
            sum += a.salary;
        }
        return sum + Presidency.salary;
    }
    public void PrintAllMembers()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(this.Name);
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($"Presidency : {Presidency.FirstName} {Presidency.LastName} {Presidency.BirthYear}");
        string outTeachers = "Teachers:";
        string outStudents = "Students:";
        string outEmployees = "Employees:";
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach(var a in teachers)
        {
            outTeachers += $"{a.FirstName} {a.LastName} {a.BirthYear} / ";
        }
        System.Console.WriteLine(outTeachers);
        Console.ForegroundColor = ConsoleColor.Blue;
        foreach(var a in students)
        {
            outStudents += $"{a.FirstName} {a.LastName} {a.BirthYear} / ";
        }
        System.Console.WriteLine(outStudents);
        Console.ForegroundColor = ConsoleColor.Red;
        foreach(var a in employees)
        {
            outEmployees += $"{a.FirstName} {a.LastName} {a.BirthYear} / ";
        }
        System.Console.WriteLine(outEmployees);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public override bool Equals(object obj)
    {
        var item = obj as Department;
        if (obj == null){
            
            return false; 
        }
        return this.Name.Equals(item.Name);
    }

}